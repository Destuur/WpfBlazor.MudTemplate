using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary.Samples.SampleComponents
{
	public partial class SecondChildComponent
	{
		[CascadingParameter]
		public string CascadingString { get; set; } = string.Empty;
		[Parameter]
		public EventCallback<string> InitiateNewString { get; set; }
	}
}
