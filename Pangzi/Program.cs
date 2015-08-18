using System;
using System.IO;

namespace Pangzi
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string filename = "";
			if (args.Length > 0) {

				filename = args [0];

				if (File.Exists (filename)) {
					string content = File.ReadAllText (filename);
					string[] lines = content.Split ('\n');

					Tokenizer tokenizer = new Tokenizer (lines);
					var ops = tokenizer.tokenize ();
					Interpreter interpreter = new Interpreter (ops);
					interpreter.Run ();
				} else {
					Console.WriteLine ("Error: file not find !");
				}
			} else {
				Console.WriteLine ("Usage: pangzi filename.pz");

				Console.Write ('a' + 1);

			}
		}
	}
}
