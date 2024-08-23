using System;
using System.ComponentModel;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200008E RID: 142
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000B9")]
	public class JPropertyDescriptor : PropertyDescriptor
	{
		// Token: 0x0600064D RID: 1613 RVA: 0x000032F6 File Offset: 0x000014F6
		[global::Cpp2ILInjected.Token(Token = "0x60006C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D02FB4", Offset = "0x1D02FB4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		public JPropertyDescriptor(string name)
		{
			throw null;
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x000032F9 File Offset: 0x000014F9
		[global::Cpp2ILInjected.Token(Token = "0x60006C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D02FC0", Offset = "0x1D02FC0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPropertyDescriptor), Member = "GetValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPropertyDescriptor), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static JObject CastInstance(object instance)
		{
			throw null;
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x000032FC File Offset: 0x000014FC
		[global::Cpp2ILInjected.Token(Token = "0x60006C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0303C", Offset = "0x1D0303C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool CanResetValue(object component)
		{
			throw null;
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x000032FF File Offset: 0x000014FF
		[global::Cpp2ILInjected.Token(Token = "0x60006C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D03044", Offset = "0x1D03044", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPropertyDescriptor), Member = "CastInstance", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(JObject))]
		public override object GetValue(object component)
		{
			throw null;
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00003302 File Offset: 0x00001502
		[global::Cpp2ILInjected.Token(Token = "0x60006C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D03100", Offset = "0x1D03100", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void ResetValue(object component)
		{
			throw null;
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00003305 File Offset: 0x00001505
		[global::Cpp2ILInjected.Token(Token = "0x60006C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D03104", Offset = "0x1D03104", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPropertyDescriptor), Member = "CastInstance", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(JObject))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void SetValue(object component, object value)
		{
			throw null;
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00003308 File Offset: 0x00001508
		[global::Cpp2ILInjected.Token(Token = "0x60006CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D032B8", Offset = "0x1D032B8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool ShouldSerializeValue(object component)
		{
			throw null;
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x0000330B File Offset: 0x0000150B
		[global::Cpp2ILInjected.Token(Token = "0x1700014B")]
		public override Type ComponentType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D032C0", Offset = "0x1D032C0", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x0000330E File Offset: 0x0000150E
		[global::Cpp2ILInjected.Token(Token = "0x1700014C")]
		public override bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0332C", Offset = "0x1D0332C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x00003311 File Offset: 0x00001511
		[global::Cpp2ILInjected.Token(Token = "0x1700014D")]
		public override Type PropertyType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D03334", Offset = "0x1D03334", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x00003314 File Offset: 0x00001514
		[global::Cpp2ILInjected.Token(Token = "0x1700014E")]
		protected override int NameHashCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D033A0", Offset = "0x1D033A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}
	}
}
