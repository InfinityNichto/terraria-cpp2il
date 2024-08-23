using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000281 RID: 641
	[AttributeUsage(AttributeTargets.All)]
	[global::Cpp2ILInjected.Token(Token = "0x2000378")]
	public sealed class ExtenderProvidedPropertyAttribute : Attribute
	{
		// Token: 0x06001500 RID: 5376 RVA: 0x00006A22 File Offset: 0x00004C22
		[global::Cpp2ILInjected.Token(Token = "0x600174B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4C170", Offset = "0x1E4C170", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExtendedPropertyDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ReflectPropertyDescriptor),
			typeof(Type),
			typeof(IExtenderProvider),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static ExtenderProvidedPropertyAttribute Create(PropertyDescriptor extenderProperty, Type receiverType, IExtenderProvider provider)
		{
			throw null;
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x00006A25 File Offset: 0x00004C25
		[global::Cpp2ILInjected.Token(Token = "0x600174C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4C670", Offset = "0x1E4C670", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ExtenderProvidedPropertyAttribute()
		{
			throw null;
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06001502 RID: 5378 RVA: 0x00006A28 File Offset: 0x00004C28
		// (set) Token: 0x06001503 RID: 5379 RVA: 0x00006A2B File Offset: 0x00004C2B
		[global::Cpp2ILInjected.Token(Token = "0x1700054B")]
		public PropertyDescriptor ExtenderProperty
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600174D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4C678", Offset = "0x1E4C678", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600174E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4C680", Offset = "0x1E4C680", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x00006A2E File Offset: 0x00004C2E
		// (set) Token: 0x06001505 RID: 5381 RVA: 0x00006A31 File Offset: 0x00004C31
		[global::Cpp2ILInjected.Token(Token = "0x1700054C")]
		public IExtenderProvider Provider
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600174F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4C688", Offset = "0x1E4C688", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001750")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4C690", Offset = "0x1E4C690", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001506 RID: 5382 RVA: 0x00006A34 File Offset: 0x00004C34
		// (set) Token: 0x06001507 RID: 5383 RVA: 0x00006A37 File Offset: 0x00004C37
		[global::Cpp2ILInjected.Token(Token = "0x1700054D")]
		public Type ReceiverType
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001751")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4C698", Offset = "0x1E4C698", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001752")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4C6A0", Offset = "0x1E4C6A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x00006A3A File Offset: 0x00004C3A
		[global::Cpp2ILInjected.Token(Token = "0x6001753")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4C6A8", Offset = "0x1E4C6A8", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x00006A3D File Offset: 0x00004C3D
		[global::Cpp2ILInjected.Token(Token = "0x6001754")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4C768", Offset = "0x1E4C768", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x00006A40 File Offset: 0x00004C40
		[global::Cpp2ILInjected.Token(Token = "0x6001755")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4C770", Offset = "0x1E4C770", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Token: 0x04000E20 RID: 3616
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001228")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private PropertyDescriptor <ExtenderProperty>k__BackingField;

		// Token: 0x04000E21 RID: 3617
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001229")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private IExtenderProvider <Provider>k__BackingField;

		// Token: 0x04000E22 RID: 3618
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400122A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Type <ReceiverType>k__BackingField;
	}
}
