using System;
using System.Collections.Generic;

namespace Pangzi
{
	public class Tokenizer
	{
		string []words = null;
		public Tokenizer (string []words)
		{
			this.words = words;
		}

		public List<Operations.Operator> tokenize() {
			List<Operations.Operator> ops = new List<Operations.Operator>();

			Operations operations = new Operations ();

			foreach (string s in words) {
				var op = operations.toOperator (s);
				ops.Add (op);
			}

			return ops;
		}
	}
}

