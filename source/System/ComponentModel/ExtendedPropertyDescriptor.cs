using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000280 RID: 640
	[global::Cpp2ILInjected.Token(Token = "0x2000377")]
	internal sealed class ExtendedPropertyDescriptor : PropertyDescriptor
	{
		// Token: 0x060014F5 RID: 5365 RVA: 0x00006A01 File Offset: 0x00004C01
		[global::Cpp2ILInjected.Token(Token = "0x6001740")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4BF28", Offset = "0x1E4BF28", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "ReflectGetExtendedProperties", MemberParameters = new object[] { typeof(IExtenderProvider) }, ReturnType = typeof(PropertyDescriptor[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MemberDescriptor),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExtenderProvidedPropertyAttribute), Member = "Create", MemberParameters = new object[]
		{
			typeof(PropertyDescriptor),
			typeof(Type),
			typeof(IExtenderProvider)
		}, ReturnType = typeof(ExtenderProvidedPropertyAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public ExtendedPropertyDescriptor(ReflectPropertyDescriptor extenderInfo, Type receiverType, IExtenderProvider provider, Attribute[] attributes)
		{
			throw null;
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x00006A04 File Offset: 0x00004C04
		[global::Cpp2ILInjected.Token(Token = "0x6001741")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4C1E0", Offset = "0x1E4C1E0", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "CreateProperty", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(PropertyDescriptor),
			typeof(Attribute[])
		}, ReturnType = typeof(PropertyDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MemberDescriptor),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public ExtendedPropertyDescriptor(PropertyDescriptor extender, Attribute[] attributes)
		{
			throw null;
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x00006A07 File Offset: 0x00004C07
		[global::Cpp2ILInjected.Token(Token = "0x6001742")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4C308", Offset = "0x1E4C308", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderCanResetValue", MemberParameters = new object[]
		{
			typeof(IExtenderProvider),
			typeof(object)
		}, ReturnType = typeof(bool))]
		public override bool CanResetValue(object comp)
		{
			throw null;
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x060014F8 RID: 5368 RVA: 0x00006A0A File Offset: 0x00004C0A
		[global::Cpp2ILInjected.Token(Token = "0x17000547")]
		public override Type ComponentType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001743")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4C320", Offset = "0x1E4C320", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x060014F9 RID: 5369 RVA: 0x00006A0D File Offset: 0x00004C0D
		[global::Cpp2ILInjected.Token(Token = "0x17000548")]
		public override bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001744")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4C334", Offset = "0x1E4C334", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x060014FA RID: 5370 RVA: 0x00006A10 File Offset: 0x00004C10
		[global::Cpp2ILInjected.Token(Token = "0x17000549")]
		public override Type PropertyType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001745")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4C420", Offset = "0x1E4C420", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderGetType", MemberParameters = new object[] { typeof(IExtenderProvider) }, ReturnType = typeof(Type))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x060014FB RID: 5371 RVA: 0x00006A13 File Offset: 0x00004C13
		[global::Cpp2ILInjected.Token(Token = "0x1700054A")]
		public override string DisplayName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001746")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4C430", Offset = "0x1E4C430", Length = "0x1D4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = "get_DisplayName", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = "GetSite", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(ISite))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x00006A16 File Offset: 0x00004C16
		[global::Cpp2ILInjected.Token(Token = "0x6001747")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4C604", Offset = "0x1E4C604", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderGetValue", MemberParameters = new object[]
		{
			typeof(IExtenderProvider),
			typeof(object)
		}, ReturnType = typeof(object))]
		public override object GetValue(object comp)
		{
			throw null;
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x00006A19 File Offset: 0x00004C19
		[global::Cpp2ILInjected.Token(Token = "0x6001748")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4C61C", Offset = "0x1E4C61C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderResetValue", MemberParameters = new object[]
		{
			typeof(IExtenderProvider),
			typeof(object),
			typeof(PropertyDescriptor)
		}, ReturnType = typeof(void))]
		public override void ResetValue(object comp)
		{
			throw null;
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x00006A1C File Offset: 0x00004C1C
		[global::Cpp2ILInjected.Token(Token = "0x6001749")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4C638", Offset = "0x1E4C638", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderSetValue", MemberParameters = new object[]
		{
			typeof(IExtenderProvider),
			typeof(object),
			typeof(object),
			typeof(PropertyDescriptor)
		}, ReturnType = typeof(void))]
		public override void SetValue(object component, object value)
		{
			throw null;
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x00006A1F File Offset: 0x00004C1F
		[global::Cpp2ILInjected.Token(Token = "0x600174A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4C658", Offset = "0x1E4C658", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderShouldSerializeValue", MemberParameters = new object[]
		{
			typeof(IExtenderProvider),
			typeof(object)
		}, ReturnType = typeof(bool))]
		public override bool ShouldSerializeValue(object comp)
		{
			throw null;
		}

		// Token: 0x04000E1E RID: 3614
		[global::Cpp2ILInjected.Token(Token = "0x4001226")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private readonly ReflectPropertyDescriptor _extenderInfo;

		// Token: 0x04000E1F RID: 3615
		[global::Cpp2ILInjected.Token(Token = "0x4001227")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private readonly IExtenderProvider _provider;
	}
}
