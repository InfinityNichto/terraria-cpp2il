using System;
using System.Collections;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Lifetime
{
	[global::Cpp2ILInjected.Token(Token = "0x200035F")]
	internal class Lease : global::System.MarshalByRefObject, ILease
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001CB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B38394", Offset = "0x1B38394", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServerIdentity), Member = "StartTrackingLifetime", MemberParameters = new object[] { typeof(ILease) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MarshalByRefObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_UtcNow", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public Lease()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000355")]
		public global::System.TimeSpan CurrentLeaseTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CBA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B384EC", Offset = "0x1B384EC", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lease), Member = "Renew", MemberParameters = new object[] { typeof(global::System.TimeSpan) }, ReturnType = typeof(global::System.TimeSpan))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lease), Member = "UpdateState", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_UtcNow", ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_Subtraction", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.DateTime)
			}, ReturnType = typeof(global::System.TimeSpan))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000356")]
		public LeaseState CurrentState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CBB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B38554", Offset = "0x1B38554", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CBC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3855C", Offset = "0x1B3855C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Activate()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000357")]
		public global::System.TimeSpan RenewOnCallTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CBD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B38568", Offset = "0x1B38568", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CBE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B38570", Offset = "0x1B38570", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lease), Member = "ProcessSponsorResponse", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_UtcNow", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_GreaterThan", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lease), Member = "get_CurrentLeaseTime", ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public global::System.TimeSpan Renew(global::System.TimeSpan renewalTime)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CBF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B385FC", Offset = "0x1B385FC", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lease), Member = "ProcessSponsorResponse", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Unregister(ISponsor obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B38724", Offset = "0x1B38724", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LeaseManager), Member = "ManageLeases", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lease), Member = "get_CurrentLeaseTime", ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_GreaterThan", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Queue), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Collections.ICollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lease), Member = "CheckNextSponsor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal void UpdateState()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CC1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B388B8", Offset = "0x1B388B8", Length = "0x238")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lease), Member = "UpdateState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lease), Member = "ProcessSponsorResponse", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lease.RenewalDelegate), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.WaitOrTimerCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.ThreadPool), Member = "RegisterWaitForSingleObject", MemberParameters = new object[]
		{
			typeof(global::System.Threading.WaitHandle),
			typeof(global::System.Threading.WaitOrTimerCallback),
			typeof(object),
			typeof(global::System.TimeSpan),
			typeof(bool)
		}, ReturnType = typeof(global::System.Threading.RegisteredWaitHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private void CheckNextSponsor()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B38C3C", Offset = "0x1B38C3C", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lease), Member = "Renew", MemberParameters = new object[] { typeof(global::System.TimeSpan) }, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lease), Member = "Unregister", MemberParameters = new object[] { typeof(ISponsor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lease), Member = "CheckNextSponsor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private void ProcessSponsorResponse(object state, bool timedOut)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000E8B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.DateTime _leaseExpireTime;

		[global::Cpp2ILInjected.Token(Token = "0x4000E8C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private LeaseState _currentState;

		[global::Cpp2ILInjected.Token(Token = "0x4000E8D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.TimeSpan _initialLeaseTime;

		[global::Cpp2ILInjected.Token(Token = "0x4000E8E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private global::System.TimeSpan _renewOnCallTime;

		[global::Cpp2ILInjected.Token(Token = "0x4000E8F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private global::System.TimeSpan _sponsorshipTimeout;

		[global::Cpp2ILInjected.Token(Token = "0x4000E90")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private global::System.Collections.ArrayList _sponsors;

		[global::Cpp2ILInjected.Token(Token = "0x4000E91")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private global::System.Collections.Queue _renewingSponsors;

		[global::Cpp2ILInjected.Token(Token = "0x4000E92")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private Lease.RenewalDelegate _renewalDelegate;

		[global::Cpp2ILInjected.Token(Token = "0x2000360")]
		private delegate global::System.TimeSpan RenewalDelegate(ILease lease);
	}
}
