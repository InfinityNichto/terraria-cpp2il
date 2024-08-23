using System;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000031 RID: 49
	[global::Cpp2ILInjected.Token(Token = "0x2000033")]
	[Serializable]
	public struct InputDeviceMatcher
	{
		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000251 RID: 593 RVA: 0x0000273E File Offset: 0x0000093E
		// (set) Token: 0x06000252 RID: 594 RVA: 0x00002741 File Offset: 0x00000941
		[global::Cpp2ILInjected.Token(Token = "0x170000C9")]
		public OptionalUInt16 VendorID
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000252")]
			[global::Cpp2ILInjected.Address(RVA = "0x198ADE8", Offset = "0x198ADE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000253")]
			[global::Cpp2ILInjected.Address(RVA = "0x198ADF0", Offset = "0x198ADF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00002744 File Offset: 0x00000944
		// (set) Token: 0x06000254 RID: 596 RVA: 0x00002747 File Offset: 0x00000947
		[global::Cpp2ILInjected.Token(Token = "0x170000CA")]
		public OptionalUInt16 ProductID
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000254")]
			[global::Cpp2ILInjected.Address(RVA = "0x198ADF8", Offset = "0x198ADF8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000255")]
			[global::Cpp2ILInjected.Address(RVA = "0x198AE00", Offset = "0x198AE00", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000255 RID: 597 RVA: 0x0000274A File Offset: 0x0000094A
		// (set) Token: 0x06000256 RID: 598 RVA: 0x0000274D File Offset: 0x0000094D
		[global::Cpp2ILInjected.Token(Token = "0x170000CB")]
		public OptionalUInt32 VersionNumber
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000256")]
			[global::Cpp2ILInjected.Address(RVA = "0x198AE08", Offset = "0x198AE08", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000257")]
			[global::Cpp2ILInjected.Address(RVA = "0x198AE10", Offset = "0x198AE10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000257 RID: 599 RVA: 0x00002750 File Offset: 0x00000950
		// (set) Token: 0x06000258 RID: 600 RVA: 0x00002753 File Offset: 0x00000953
		[global::Cpp2ILInjected.Token(Token = "0x170000CC")]
		public OptionalInputDeviceDriverType DriverType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000258")]
			[global::Cpp2ILInjected.Address(RVA = "0x198AE18", Offset = "0x198AE18", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000259")]
			[global::Cpp2ILInjected.Address(RVA = "0x198AE20", Offset = "0x198AE20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000259 RID: 601 RVA: 0x00002756 File Offset: 0x00000956
		// (set) Token: 0x0600025A RID: 602 RVA: 0x00002759 File Offset: 0x00000959
		[global::Cpp2ILInjected.Token(Token = "0x170000CD")]
		public OptionalInputDeviceTransportType TransportType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600025A")]
			[global::Cpp2ILInjected.Address(RVA = "0x198AE28", Offset = "0x198AE28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600025B")]
			[global::Cpp2ILInjected.Address(RVA = "0x198AE30", Offset = "0x198AE30", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600025B RID: 603 RVA: 0x0000275C File Offset: 0x0000095C
		// (set) Token: 0x0600025C RID: 604 RVA: 0x0000275F File Offset: 0x0000095F
		[global::Cpp2ILInjected.Token(Token = "0x170000CE")]
		public string NameLiteral
		{
			[global::Cpp2ILInjected.Token(Token = "0x600025C")]
			[global::Cpp2ILInjected.Address(RVA = "0x198AE38", Offset = "0x198AE38", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600025D")]
			[global::Cpp2ILInjected.Address(RVA = "0x198AE40", Offset = "0x198AE40", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600025D RID: 605 RVA: 0x00002762 File Offset: 0x00000962
		// (set) Token: 0x0600025E RID: 606 RVA: 0x00002765 File Offset: 0x00000965
		[global::Cpp2ILInjected.Token(Token = "0x170000CF")]
		public string NamePattern
		{
			[global::Cpp2ILInjected.Token(Token = "0x600025E")]
			[global::Cpp2ILInjected.Address(RVA = "0x198AE48", Offset = "0x198AE48", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600025F")]
			[global::Cpp2ILInjected.Address(RVA = "0x198AE50", Offset = "0x198AE50", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00002768 File Offset: 0x00000968
		[global::Cpp2ILInjected.Token(Token = "0x6000260")]
		[global::Cpp2ILInjected.Address(RVA = "0x198AE58", Offset = "0x198AE58", Length = "0x11A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDeviceProfile), Member = "Matches", MemberParameters = new object[]
		{
			typeof(InputDeviceInfo),
			typeof(InputDeviceMatcher[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "get_Value", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt32), Member = "get_Value", ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalInputDeviceDriverType), Member = "get_Value", ReturnType = typeof(InputDeviceDriverType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalInputDeviceTransportType), Member = "get_Value", ReturnType = typeof(InputDeviceTransportType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(RegexOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal bool Matches(InputDeviceInfo deviceInfo)
		{
			throw null;
		}

		// Token: 0x04000247 RID: 583
		[Hexadecimal]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400024E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private OptionalUInt16 vendorID;

		// Token: 0x04000248 RID: 584
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400024F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private OptionalUInt16 productID;

		// Token: 0x04000249 RID: 585
		[SerializeField]
		[Hexadecimal]
		[global::Cpp2ILInjected.Token(Token = "0x4000250")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private OptionalUInt32 versionNumber;

		// Token: 0x0400024A RID: 586
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000251")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private OptionalInputDeviceDriverType driverType;

		// Token: 0x0400024B RID: 587
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000252")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private OptionalInputDeviceTransportType transportType;

		// Token: 0x0400024C RID: 588
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000253")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string nameLiteral;

		// Token: 0x0400024D RID: 589
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000254")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string namePattern;
	}
}
