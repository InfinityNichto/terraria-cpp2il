using System;
using System.Buffers;
using System.Collections.Concurrent;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020004E7 RID: 1255
	[global::Cpp2ILInjected.Token(Token = "0x20005DA")]
	public class EventSource : global::System.IDisposable
	{
		// Token: 0x06002A1F RID: 10783 RVA: 0x0001BA97 File Offset: 0x00019C97
		[global::Cpp2ILInjected.Token(Token = "0x6002D80")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C06408", Offset = "0x1C06408", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Concurrent.CDSCollectionETWBCLProvider), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Concurrent.CDSCollectionETWBCLProvider), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetEventSource", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetEventSource", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		protected EventSource()
		{
			throw null;
		}

		// Token: 0x06002A20 RID: 10784 RVA: 0x0001BA9A File Offset: 0x00019C9A
		[global::Cpp2ILInjected.Token(Token = "0x6002D81")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0643C", Offset = "0x1C0643C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EventSource(string eventSourceName)
		{
			throw null;
		}

		// Token: 0x06002A21 RID: 10785 RVA: 0x0001BA9D File Offset: 0x00019C9D
		[global::Cpp2ILInjected.Token(Token = "0x6002D82")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C06464", Offset = "0x1C06464", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal EventSource(global::System.Guid eventSourceGuid, string eventSourceName)
		{
			throw null;
		}

		// Token: 0x06002A22 RID: 10786 RVA: 0x0001BAA0 File Offset: 0x00019CA0
		[global::Cpp2ILInjected.Token(Token = "0x6002D83")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0648C", Offset = "0x1C0648C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x17000659 RID: 1625
		// (set) Token: 0x06002A23 RID: 10787 RVA: 0x0001BAA3 File Offset: 0x00019CA3
		[global::Cpp2ILInjected.Token(Token = "0x170006ED")]
		private string Name
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002D84")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0652C", Offset = "0x1C0652C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06002A24 RID: 10788 RVA: 0x0001BAA6 File Offset: 0x00019CA6
		[global::Cpp2ILInjected.Token(Token = "0x6002D85")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C06534", Offset = "0x1C06534", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Concurrent.ConcurrentDictionary<, >), Member = "AcquireAllLocks", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1.LockedStack", Member = "Trim", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(int),
			"MemoryPressure<T>",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Buffers.TlsOverPerCoreLockedStacksArrayPool<>), Member = "Rent", MemberParameters = new object[] { typeof(int) }, ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Buffers.TlsOverPerCoreLockedStacksArrayPool<>), Member = "Return", MemberParameters = new object[]
		{
			"T[]",
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Buffers.TlsOverPerCoreLockedStacksArrayPool<>), Member = "Trim", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetEventSource", Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetEventSource", Member = "WriteEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetEventSource", Member = "WriteEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string),
			"System.Byte[]"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetEventSource", Member = "WriteEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetEventSource", Member = "WriteEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetEventSource", Member = "WriteEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetEventSource", Member = "WriteEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CommandStream", Member = "ContinueCommandPipeline", ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		public bool IsEnabled()
		{
			throw null;
		}

		// Token: 0x06002A25 RID: 10789 RVA: 0x0001BAA9 File Offset: 0x00019CA9
		[global::Cpp2ILInjected.Token(Token = "0x6002D86")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0653C", Offset = "0x1C0653C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool IsEnabled(EventLevel level, EventKeywords keywords)
		{
			throw null;
		}

		// Token: 0x06002A26 RID: 10790 RVA: 0x0001BAAC File Offset: 0x00019CAC
		[global::Cpp2ILInjected.Token(Token = "0x6002D87")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C06544", Offset = "0x1C06544", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x06002A27 RID: 10791 RVA: 0x0001BAAF File Offset: 0x00019CAF
		[global::Cpp2ILInjected.Token(Token = "0x6002D88")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C065B0", Offset = "0x1C065B0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x06002A28 RID: 10792 RVA: 0x0001BAB2 File Offset: 0x00019CB2
		[global::Cpp2ILInjected.Token(Token = "0x6002D89")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C065B4", Offset = "0x1C065B4", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		protected void WriteEvent(int eventId, int arg1)
		{
			throw null;
		}

		// Token: 0x06002A29 RID: 10793 RVA: 0x0001BAB5 File Offset: 0x00019CB5
		[global::Cpp2ILInjected.Token(Token = "0x6002D8A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C06660", Offset = "0x1C06660", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Buffers.ArrayPoolEventSource), Member = "BufferTrimPoll", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		protected void WriteEvent(int eventId, int arg1, int arg2)
		{
			throw null;
		}

		// Token: 0x06002A2A RID: 10794 RVA: 0x0001BAB8 File Offset: 0x00019CB8
		[global::Cpp2ILInjected.Token(Token = "0x6002D8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C06744", Offset = "0x1C06744", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Buffers.ArrayPoolEventSource), Member = "BufferReturned", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Buffers.ArrayPoolEventSource), Member = "BufferTrimmed", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		protected void WriteEvent(int eventId, int arg1, int arg2, int arg3)
		{
			throw null;
		}

		// Token: 0x06002A2B RID: 10795 RVA: 0x0001BABB File Offset: 0x00019CBB
		[global::Cpp2ILInjected.Token(Token = "0x6002D8C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0665C", Offset = "0x1C0665C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected void WriteEvent(int eventId, params object[] args)
		{
			throw null;
		}

		// Token: 0x06002A2C RID: 10796 RVA: 0x0001BABE File Offset: 0x00019CBE
		[global::Cpp2ILInjected.Token(Token = "0x6002D8D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C06864", Offset = "0x1C06864", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetEventSource", Member = "Enter", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetEventSource", Member = "Exit", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetEventSource", Member = "Info", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetEventSource", Member = "ErrorMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetEventSource", Member = "CriticalFailure", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		protected void WriteEvent(int eventId, string arg1, string arg2, string arg3)
		{
			throw null;
		}

		// Token: 0x06002A2D RID: 10797 RVA: 0x0001BAC1 File Offset: 0x00019CC1
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6002D8E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C06924", Offset = "0x1C06924", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetEventSource", Member = "WriteEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetEventSource", Member = "WriteEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string),
			"System.Byte[]"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetEventSource", Member = "WriteEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetEventSource", Member = "WriteEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetEventSource", Member = "WriteEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetEventSource", Member = "WriteEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		protected unsafe void WriteEventCore(int eventId, int eventDataCount, EventSource.EventData* data)
		{
			throw null;
		}

		// Token: 0x0400159E RID: 5534
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400198B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string <Name>k__BackingField;

		// Token: 0x0200063D RID: 1597
		[global::Cpp2ILInjected.Token(Token = "0x20005DB")]
		protected internal struct EventData
		{
			// Token: 0x1700078F RID: 1935
			// (set) Token: 0x06004235 RID: 16949 RVA: 0x000200F3 File Offset: 0x0001E2F3
			[global::Cpp2ILInjected.Token(Token = "0x170006EE")]
			public global::System.IntPtr DataPointer
			{
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002D8F")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C06928", Offset = "0x1C06928", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000790 RID: 1936
			// (set) Token: 0x06004236 RID: 16950 RVA: 0x000200F6 File Offset: 0x0001E2F6
			[global::Cpp2ILInjected.Token(Token = "0x170006EF")]
			public int Size
			{
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002D90")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C06930", Offset = "0x1C06930", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000791 RID: 1937
			// (set) Token: 0x06004237 RID: 16951 RVA: 0x000200F9 File Offset: 0x0001E2F9
			[global::Cpp2ILInjected.Token(Token = "0x170006F0")]
			internal int Reserved
			{
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6002D91")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C06938", Offset = "0x1C06938", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x04001A73 RID: 6771
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400198C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private global::System.IntPtr <DataPointer>k__BackingField;

			// Token: 0x04001A74 RID: 6772
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400198D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			private int <Size>k__BackingField;

			// Token: 0x04001A75 RID: 6773
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400198E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			private int <Reserved>k__BackingField;
		}
	}
}
