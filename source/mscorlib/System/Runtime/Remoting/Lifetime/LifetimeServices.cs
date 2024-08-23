using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Xml;

namespace System.Runtime.Remoting.Lifetime
{
	// Token: 0x020002C3 RID: 707
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000364")]
	public sealed class LifetimeServices
	{
		// Token: 0x06001AA8 RID: 6824 RVA: 0x00018FE3 File Offset: 0x000171E3
		[global::Cpp2ILInjected.Token(Token = "0x6001CD1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B39830", Offset = "0x1B39830", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LeaseManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "FromSeconds", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "FromMinutes", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static LifetimeServices()
		{
			throw null;
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06001AA9 RID: 6825 RVA: 0x00018FE6 File Offset: 0x000171E6
		// (set) Token: 0x06001AAA RID: 6826 RVA: 0x00018FE9 File Offset: 0x000171E9
		[global::Cpp2ILInjected.Token(Token = "0x17000358")]
		public static global::System.TimeSpan LeaseManagerPollTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CD2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B39934", Offset = "0x1B39934", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001CD3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B3998C", Offset = "0x1B3998C", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConfigHandler), Member = "ReadLifetine", MemberParameters = new object[] { typeof(Mono.Xml.SmallXmlParser.IAttrList) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LeaseManager), Member = "SetPollTime", MemberParameters = new object[] { typeof(global::System.TimeSpan) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06001AAB RID: 6827 RVA: 0x00018FEC File Offset: 0x000171EC
		// (set) Token: 0x06001AAC RID: 6828 RVA: 0x00018FEF File Offset: 0x000171EF
		[global::Cpp2ILInjected.Token(Token = "0x17000359")]
		public static global::System.TimeSpan LeaseTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CD4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B399F8", Offset = "0x1B399F8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001CD5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B39A50", Offset = "0x1B39A50", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06001AAD RID: 6829 RVA: 0x00018FF2 File Offset: 0x000171F2
		// (set) Token: 0x06001AAE RID: 6830 RVA: 0x00018FF5 File Offset: 0x000171F5
		[global::Cpp2ILInjected.Token(Token = "0x1700035A")]
		public static global::System.TimeSpan RenewOnCallTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CD6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B39AAC", Offset = "0x1B39AAC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001CD7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B39B04", Offset = "0x1B39B04", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06001AAF RID: 6831 RVA: 0x00018FF8 File Offset: 0x000171F8
		// (set) Token: 0x06001AB0 RID: 6832 RVA: 0x00018FFB File Offset: 0x000171FB
		[global::Cpp2ILInjected.Token(Token = "0x1700035B")]
		public static global::System.TimeSpan SponsorshipTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CD8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B39B60", Offset = "0x1B39B60", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001CD9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B39BB8", Offset = "0x1B39BB8", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x00018FFE File Offset: 0x000171FE
		[global::Cpp2ILInjected.Token(Token = "0x6001CDA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B39C14", Offset = "0x1B39C14", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServerIdentity), Member = "StartTrackingLifetime", MemberParameters = new object[] { typeof(ILease) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LeaseManager), Member = "TrackLifetime", MemberParameters = new object[] { typeof(ServerIdentity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void TrackLifetime(ServerIdentity identity)
		{
			throw null;
		}

		// Token: 0x04000BB8 RID: 3000
		[global::Cpp2ILInjected.Token(Token = "0x4000E9C")]
		private static global::System.TimeSpan _leaseManagerPollTime;

		// Token: 0x04000BB9 RID: 3001
		[global::Cpp2ILInjected.Token(Token = "0x4000E9D")]
		private static global::System.TimeSpan _leaseTime;

		// Token: 0x04000BBA RID: 3002
		[global::Cpp2ILInjected.Token(Token = "0x4000E9E")]
		private static global::System.TimeSpan _renewOnCallTime;

		// Token: 0x04000BBB RID: 3003
		[global::Cpp2ILInjected.Token(Token = "0x4000E9F")]
		private static global::System.TimeSpan _sponsorshipTimeout;

		// Token: 0x04000BBC RID: 3004
		[global::Cpp2ILInjected.Token(Token = "0x4000EA0")]
		private static LeaseManager _leaseManager;
	}
}
