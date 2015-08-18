using System;

namespace Pangzi
{
	public class Operations
	{

		public enum Operator {
			Increment,
			Decrement,
			Output,
			Input,
			Right,
			Left,
			Jump,
			JumpBack,
			Unknown
		}
		public Operations ()
		{
		}

		public Operator toOperator(string s) {
			switch (s) {
			case "pangzi":
				return Operator.Increment;
			case "PangZi":
				return Operator.Decrement;
			case "pangZii":
				return Operator.Input;
			case "zpangzi":
				return Operator.Jump;
			case "hpangzi":
				return Operator.JumpBack;
			case "nspangzi":
				return Operator.Left;
			case "snpangzi":
				return Operator.Right;
			case "PANGZII":
				return Operator.Output;
			default:
				return Operator.Unknown;
			}
		}
	}
}

