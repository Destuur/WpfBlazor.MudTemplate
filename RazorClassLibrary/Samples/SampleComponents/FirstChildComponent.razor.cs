using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary.Samples.SampleComponents
{
	public partial class FirstChildComponent
	{
		[Parameter]
		public EventCallback<string> ForwardNewString { get; set; }
	}
}
