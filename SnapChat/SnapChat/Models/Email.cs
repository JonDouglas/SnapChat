using System;
using System.Collections.Generic;
using System.Text;

namespace SnapChat.Models
{
    public class Email
    {
		public Uri Icon { get; set; }
		public string Name { get; set; }
		public int EmailCount { get; set; }
		public string Subject { get; set; }
		public string Body { get; set; }
		public string Date { get; set; }
	}
}
