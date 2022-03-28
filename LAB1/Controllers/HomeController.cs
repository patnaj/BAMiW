﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LAB1.Models;
using LAB1.Data;

//using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace LAB1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        
            User_Id = 1;
        }

        public int User_Id {get; set;}

    
        public IActionResult Index(int? id, string find = null)
        {
            //HTTP Client v0.34.0 Marcel J. Kloubert



            // ModelState.AddModelError("find", "zły format");
            // System.Text.RegularExpressions.Regex
            //var rx = new System.Text.RegularExpressions.Regex(@"Expressions");
            //rx.IsMatch(find);
            //rx.Replace(find, "replacment");
            //https://regex101.com/
            
            // ' UNION ALL SELECT '6', '2022-03-02', name, '2', null FROM sqlite_schema --
            // ' UNION ALL SELECT rootpage, '2022-03-02', name, '2', null FROM sqlite_schema --

            ViewBag.ID = id;
            ViewBag.find = find;
            try{
                if(id != null){
                    var res = _context.Invoices.FromSqlRaw($"SELECT * FROM [Invoices] WHERE [UserID]='{User_Id}' [ID]='{id}'");
                    return View(res.ToList());
                }
                if(find!=null){
                    var res = _context.Invoices.FromSqlRaw($"SELECT * FROM [Invoices] WHERE [UserID]='{User_Id}' AND [Address] like '%{find}%'");
                    return View(res.ToList());    
                }

                return View(_context.Invoices.Where(m=>m.UserID == this.User_Id).ToList());
            } catch(Exception ex){
                ModelState.AddModelError("Exeption", ex.Message);
                return View(new List<InvoiceModel>());
            }


            // if(id != null)
            //     return View(_context.Invoices.Where(m=>m.ID == id).ToList());
            // return View(_context.Invoices.Where(m=>m.UserID == this.User_Id).ToList());
        }



        public IActionResult Privacy()
        {
            return View();
        }

        public String Raport()
        {
            String raport = "Raport z bazy:";


            return raport;
        }

        [HttpPost]
        public String Raport(string text)
        {
            String raport = "Raport z bazy:";


            return raport;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public string LogInfo(string find = null)
        {
            
            var cmd = System.IO.File.Exists(@"/bin/bash") ? @"/bin/bash" : "cmd.exe";
            var arg = System.IO.File.Exists(@"/bin/bash") ? $"-c {find}" : $"/C {find}";

            var psi = new ProcessStartInfo
            {
                FileName = cmd,
                Arguments = arg,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            var proc = new Process
            {
                StartInfo = psi
            };

            string result = "";

            proc.Start();
            Task.WaitAll(
                Task.Run(() => {
                while (!proc.StandardOutput.EndOfStream)
                {
                    result += proc.StandardOutput.ReadLine();                    
                }
                }), 
                Task.Run(() => {
                while (!proc.StandardError.EndOfStream)
                {
                    result += proc.StandardError.ReadLine();
                }})
            );


            proc.WaitForExit();
            return proc.ExitCode.ToString() + result;
        }



    }
}
