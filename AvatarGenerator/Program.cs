using Jdenticon;
using System;

namespace AvatarGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length != 2){
                Console.WriteLine($"To less params ({args.Length})!\nHelp:\nAvatarGenerator <name> <output>");
                return;
            }
            //Console.WriteLine($"Gen avatart: {args}");
            Console.WriteLine( Identicon
                .FromValue(args[0], size: 100)
                .ToSvg() );
                //.SaveAsSvg(args[1]);
        }
    }
}
