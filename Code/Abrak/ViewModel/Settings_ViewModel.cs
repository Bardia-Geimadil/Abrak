using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abrak.ViewModel
{
    class Settings_ViewModel
    {

		private static string _apiKey = "a2cdc90633184956ab2181732250602";

		public static string API_Key
		{
			get { return _apiKey; }
			set { _apiKey = value; }
		}
			


	}
}
