using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	// Token: 0x020001C0 RID: 448
	[global::Cpp2ILInjected.Token(Token = "0x20002A2")]
	public abstract class NetworkInterface
	{
		// Token: 0x0600108F RID: 4239 RVA: 0x00005DC2 File Offset: 0x00003FC2
		[global::Cpp2ILInjected.Token(Token = "0x6001288")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1C934", Offset = "0x1E1C934", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Client", Member = "GetIPAddress", ReturnType = typeof(IPAddress))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.TcpAddress", Member = "IsLocalHost", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static NetworkInterface[] GetAllNetworkInterfaces()
		{
			throw null;
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06001090 RID: 4240 RVA: 0x00005DC5 File Offset: 0x00003FC5
		[global::Cpp2ILInjected.Token(Token = "0x17000446")]
		public virtual string Description
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001289")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1CA70", Offset = "0x1E1CA70", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x00005DC8 File Offset: 0x00003FC8
		[global::Cpp2ILInjected.Token(Token = "0x600128A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1CAA8", Offset = "0x1E1CAA8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual IPInterfaceProperties GetIPProperties()
		{
			throw null;
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06001092 RID: 4242 RVA: 0x00005DCB File Offset: 0x00003FCB
		[global::Cpp2ILInjected.Token(Token = "0x17000447")]
		public virtual OperationalStatus OperationalStatus
		{
			[global::Cpp2ILInjected.Token(Token = "0x600128B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1CAE0", Offset = "0x1E1CAE0", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06001093 RID: 4243 RVA: 0x00005DCE File Offset: 0x00003FCE
		[global::Cpp2ILInjected.Token(Token = "0x17000448")]
		public virtual NetworkInterfaceType NetworkInterfaceType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600128C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1CB18", Offset = "0x1E1CB18", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x00005DD1 File Offset: 0x00003FD1
		[global::Cpp2ILInjected.Token(Token = "0x600128D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1CB50", Offset = "0x1E1CB50", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected NetworkInterface()
		{
			throw null;
		}
	}
}
