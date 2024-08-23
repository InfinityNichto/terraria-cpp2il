using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000256 RID: 598
	[global::Cpp2ILInjected.Token(Token = "0x2000348")]
	public class ArrayConverter : CollectionConverter
	{
		// Token: 0x0600139B RID: 5019 RVA: 0x00006629 File Offset: 0x00004829
		[global::Cpp2ILInjected.Token(Token = "0x60015DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3D9B4", Offset = "0x1E3D9B4", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionConverter), Member = "ConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			throw null;
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x0000662C File Offset: 0x0000482C
		[global::Cpp2ILInjected.Token(Token = "0x60015DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3DB74", Offset = "0x1E3DB74", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetLength", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayConverter.ArrayPropertyDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = ".ctor", MemberParameters = new object[] { typeof(PropertyDescriptor[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			throw null;
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x0000662F File Offset: 0x0000482F
		[global::Cpp2ILInjected.Token(Token = "0x60015DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3DDE8", Offset = "0x1E3DDE8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			throw null;
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x00006632 File Offset: 0x00004832
		[global::Cpp2ILInjected.Token(Token = "0x60015DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3DDF0", Offset = "0x1E3DDF0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionConverter), Member = ".ctor", ReturnType = typeof(void))]
		public ArrayConverter()
		{
			throw null;
		}

		// Token: 0x02000454 RID: 1108
		[global::Cpp2ILInjected.Token(Token = "0x2000349")]
		private class ArrayPropertyDescriptor : TypeConverter.SimplePropertyDescriptor
		{
			// Token: 0x06001ED5 RID: 7893 RVA: 0x000084FE File Offset: 0x000066FE
			[global::Cpp2ILInjected.Token(Token = "0x60015DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3DD30", Offset = "0x1E3DD30", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArrayConverter), Member = "GetProperties", MemberParameters = new object[]
			{
				typeof(ITypeDescriptorContext),
				typeof(object),
				typeof(Attribute[])
			}, ReturnType = typeof(PropertyDescriptorCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ComponentModel.TypeConverter.SimplePropertyDescriptor", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(string),
				typeof(Type),
				typeof(Attribute[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public ArrayPropertyDescriptor(Type arrayType, Type elementType, int index)
			{
				throw null;
			}

			// Token: 0x06001ED6 RID: 7894 RVA: 0x00008501 File Offset: 0x00006701
			[global::Cpp2ILInjected.Token(Token = "0x60015DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3DDF8", Offset = "0x1E3DDF8", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetLength", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override object GetValue(object instance)
			{
				throw null;
			}

			// Token: 0x06001ED7 RID: 7895 RVA: 0x00008504 File Offset: 0x00006704
			[global::Cpp2ILInjected.Token(Token = "0x60015E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3DEA4", Offset = "0x1E3DEA4", Length = "0x100")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetLength", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new object[]
			{
				typeof(object),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public override void SetValue(object instance, object value)
			{
				throw null;
			}

			// Token: 0x04001384 RID: 4996
			[global::Cpp2ILInjected.Token(Token = "0x40011B2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
			private readonly int _index;
		}
	}
}
