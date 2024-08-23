using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x0200023A RID: 570
	[AttributeUsage(AttributeTargets.All)]
	[global::Cpp2ILInjected.Token(Token = "0x200032B")]
	public class DefaultValueAttribute : Attribute
	{
		// Token: 0x060012DB RID: 4827 RVA: 0x00006422 File Offset: 0x00004622
		[global::Cpp2ILInjected.Token(Token = "0x6001519")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3962C", Offset = "0x1E3962C", Length = "0x2B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultValueAttribute), Member = "<.ctor>g__TryConvertFromInvariantString|2_0", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "Parse", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public DefaultValueAttribute(Type type, string value)
		{
			throw null;
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x00006425 File Offset: 0x00004625
		[global::Cpp2ILInjected.Token(Token = "0x600151A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E39ACC", Offset = "0x1E39ACC", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DefaultValueAttribute(char value)
		{
			throw null;
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x00006428 File Offset: 0x00004628
		[global::Cpp2ILInjected.Token(Token = "0x600151B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E39B38", Offset = "0x1E39B38", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DefaultValueAttribute(byte value)
		{
			throw null;
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x0000642B File Offset: 0x0000462B
		[global::Cpp2ILInjected.Token(Token = "0x600151C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E39BA4", Offset = "0x1E39BA4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DefaultValueAttribute(short value)
		{
			throw null;
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x0000642E File Offset: 0x0000462E
		[global::Cpp2ILInjected.Token(Token = "0x600151D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E39C10", Offset = "0x1E39C10", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DefaultValueAttribute(int value)
		{
			throw null;
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x00006431 File Offset: 0x00004631
		[global::Cpp2ILInjected.Token(Token = "0x600151E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E39C7C", Offset = "0x1E39C7C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DefaultValueAttribute(long value)
		{
			throw null;
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x00006434 File Offset: 0x00004634
		[global::Cpp2ILInjected.Token(Token = "0x600151F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E39CE8", Offset = "0x1E39CE8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DefaultValueAttribute(float value)
		{
			throw null;
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x00006437 File Offset: 0x00004637
		[global::Cpp2ILInjected.Token(Token = "0x6001520")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E39D54", Offset = "0x1E39D54", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DefaultValueAttribute(double value)
		{
			throw null;
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x0000643A File Offset: 0x0000463A
		[global::Cpp2ILInjected.Token(Token = "0x6001521")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E39DC0", Offset = "0x1E39DC0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DefaultValueAttribute(bool value)
		{
			throw null;
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x0000643D File Offset: 0x0000463D
		[global::Cpp2ILInjected.Token(Token = "0x6001522")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E39E2C", Offset = "0x1E39E2C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DefaultValueAttribute(string value)
		{
			throw null;
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x00006440 File Offset: 0x00004640
		[global::Cpp2ILInjected.Token(Token = "0x6001523")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E39E54", Offset = "0x1E39E54", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DefaultValueAttribute(object value)
		{
			throw null;
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x00006443 File Offset: 0x00004643
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001524")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E39E7C", Offset = "0x1E39E7C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DefaultValueAttribute(sbyte value)
		{
			throw null;
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x00006446 File Offset: 0x00004646
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001525")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E39EE8", Offset = "0x1E39EE8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DefaultValueAttribute(ushort value)
		{
			throw null;
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x00006449 File Offset: 0x00004649
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001526")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E39F54", Offset = "0x1E39F54", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DefaultValueAttribute(uint value)
		{
			throw null;
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x0000644C File Offset: 0x0000464C
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001527")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E39FC0", Offset = "0x1E39FC0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DefaultValueAttribute(ulong value)
		{
			throw null;
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x060012EA RID: 4842 RVA: 0x0000644F File Offset: 0x0000464F
		[global::Cpp2ILInjected.Token(Token = "0x170004D5")]
		public virtual object Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001528")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3A02C", Offset = "0x1E3A02C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x00006452 File Offset: 0x00004652
		[global::Cpp2ILInjected.Token(Token = "0x6001529")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A034", Offset = "0x1E3A034", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x00006455 File Offset: 0x00004655
		[global::Cpp2ILInjected.Token(Token = "0x600152A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A130", Offset = "0x1E3A130", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x00006458 File Offset: 0x00004658
		[global::Cpp2ILInjected.Token(Token = "0x600152B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A138", Offset = "0x1E3A138", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected void SetValue(object value)
		{
			throw null;
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x0000645B File Offset: 0x0000465B
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x600152C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E398E4", Offset = "0x1E398E4", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultValueAttribute), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		internal static bool Method_Internal_Static_Boolean_Type_String_Object_0(Type typeToConvert, string stringValue, out object conversionResult)
		{
			throw null;
		}

		// Token: 0x04000D6F RID: 3439
		[global::Cpp2ILInjected.Token(Token = "0x400116C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object _value;

		// Token: 0x04000D70 RID: 3440
		[global::Cpp2ILInjected.Token(Token = "0x400116D")]
		private static object s_convertFromInvariantString;
	}
}
