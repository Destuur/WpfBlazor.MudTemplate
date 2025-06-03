using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary.Samples
{
	// Always make sure classes in code behind files are marked as partial
	public partial class SampleParentPage
	{
		public string CascadingString { get; set; } = "Hello world!";

		private void ClickHandler(string newString)
		{
			CascadingString = newString;
		}
	}
}
