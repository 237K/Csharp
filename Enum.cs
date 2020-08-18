using System;
using static System.Console;

namespace Enum
{
	public class Enum
	{
		enum DialogResult {YES, NO, CANCEL, CONFIRM, OK}
		static void Main(string[] args)
        {
			DialogResult result = DialogResult.YES;
			WriteLine(result == DialogResult.YES);
			WriteLine(result == DialogResult.NO);
			WriteLine(result == DialogResult.CANCEL);
			WriteLine(result == DialogResult.CONFIRM);
			WriteLine(result == DialogResult.OK);
        }
	}
}