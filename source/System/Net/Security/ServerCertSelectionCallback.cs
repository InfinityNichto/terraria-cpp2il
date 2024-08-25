using System;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;

namespace System.Net.Security
{
	[global::Cpp2ILInjected.Token(Token = "0x2000322")]
	internal delegate X509Certificate ServerCertSelectionCallback(string hostName);
}
