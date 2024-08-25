using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Xml;

namespace System.Runtime.Remoting.Lifetime
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000364")]
	public sealed class LifetimeServices
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x4000E9C")]
		private static global::System.TimeSpan _leaseManagerPollTime;

		[global::Cpp2ILInjected.Token(Token = "0x4000E9D")]
		private static global::System.TimeSpan _leaseTime;

		[global::Cpp2ILInjected.Token(Token = "0x4000E9E")]
		private static global::System.TimeSpan _renewOnCallTime;

		[global::Cpp2ILInjected.Token(Token = "0x4000E9F")]
		private static global::System.TimeSpan _sponsorshipTimeout;

		[global::Cpp2ILInjected.Token(Token = "0x4000EA0")]
		private static LeaseManager _leaseManager;
	}
}
