using System;
using System.Collections.Generic;

namespace Pangzi
{
	public class Interpreter
	{
		List<Operations.Operator> ops = null;
		List<char> memory = null;
		int pointer = 0;
		public Interpreter (List<Operations.Operator> ops)
		{
			this.ops = ops;
			memory = new List<char> ();
			for (int i = 0; i < 30000; i++) {
				memory.Add ((char)0);
			}
		}

		public void Run() {
			int counter = 0;

			while(counter < ops.Count) {

//				if (ops [counter] == Operations.Operator.Output) {
//					Console.WriteLine ("aaa");
//				}
				switch (ops [counter]) {
				case Operations.Operator.Increment:
					increment ();
					break;
				case Operations.Operator.Decrement:
					decrement ();
					break;
				case Operations.Operator.Input:
					input ();
					break;
				case Operations.Operator.Output:
					output ();
					break;
				case Operations.Operator.Left:
					left ();
					break;
				case Operations.Operator.Right:
					right ();
					break;

				case Operations.Operator.Jump:
					jump (ref counter);
					break;
				case Operations.Operator.JumpBack:
					jump_back (ref counter);
					break;
				}
				counter++;
			}
		}

		public void left() {
			pointer -= 1;
		}

		public void right () {
			pointer += 1;
		}

		public void input() {
			this.memory[pointer] = Convert.ToChar(Console.Read());
		}

		public void output() {
			Console.Write (Convert.ToChar(this.memory [pointer]));
		}

		public void increment() {
			this.memory [pointer] += (char) 1;
		}

		public void decrement() {
			this.memory [pointer] -= (char) 1;
		}

		public void jump (ref int counter) {
			int bal = 1;
			if (memory [pointer] == (char)0) {
				while(true) {
					counter += 1;
					if (ops [counter] == Operations.Operator.Jump) {
						bal += 1;
					} else if(ops[counter] == Operations.Operator.JumpBack) {
						bal -= 1;
					}
					if (bal == 0) {
						break;
					}
				}
			}
		}

		public void jump_back(ref int counter) {
			int bal = 0;
			while (true) {
				if (ops [counter] == Operations.Operator.Jump) {
					bal += 1;
				} else if (ops [counter] == Operations.Operator.JumpBack) {
					bal -= 1;
				}
				counter -= 1;
				if (bal == 0) {
					break;
				}
			}
		}
	}
}

