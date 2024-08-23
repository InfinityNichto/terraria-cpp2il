using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x0200026A RID: 618
	[global::Cpp2ILInjected.Token(Token = "0x2000360")]
	public abstract class CustomTypeDescriptor : ICustomTypeDescriptor
	{
		// Token: 0x0600143D RID: 5181 RVA: 0x000067E8 File Offset: 0x000049E8
		[global::Cpp2ILInjected.Token(Token = "0x6001684")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E46E18", Offset = "0x1E46E18", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptionProvider.EmptyCustomTypeDescriptor", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptionProvider), Member = "GetExtendedTypeDescriptor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptionProvider), Member = "GetTypeDescriptor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected CustomTypeDescriptor()
		{
			throw null;
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x000067EB File Offset: 0x000049EB
		[global::Cpp2ILInjected.Token(Token = "0x6001685")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E46E20", Offset = "0x1E46E20", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.AttributeProvider.AttributeTypeDescriptor", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Attribute[]),
			typeof(ICustomTypeDescriptor)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.AttributeProvider", Member = "GetTypeDescriptor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected CustomTypeDescriptor(ICustomTypeDescriptor parent)
		{
			throw null;
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x000067EE File Offset: 0x000049EE
		[global::Cpp2ILInjected.Token(Token = "0x6001686")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E46E48", Offset = "0x1E46E48", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.AttributeProvider.AttributeTypeDescriptor", Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual AttributeCollection GetAttributes()
		{
			throw null;
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x000067F1 File Offset: 0x000049F1
		[global::Cpp2ILInjected.Token(Token = "0x6001687")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E46F20", Offset = "0x1E46F20", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual string GetClassName()
		{
			throw null;
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x000067F4 File Offset: 0x000049F4
		[global::Cpp2ILInjected.Token(Token = "0x6001688")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E46FD0", Offset = "0x1E46FD0", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual string GetComponentName()
		{
			throw null;
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x000067F7 File Offset: 0x000049F7
		[global::Cpp2ILInjected.Token(Token = "0x6001689")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E47080", Offset = "0x1E47080", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual TypeConverter GetConverter()
		{
			throw null;
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x000067FA File Offset: 0x000049FA
		[global::Cpp2ILInjected.Token(Token = "0x600168A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E47158", Offset = "0x1E47158", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual EventDescriptor GetDefaultEvent()
		{
			throw null;
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x000067FD File Offset: 0x000049FD
		[global::Cpp2ILInjected.Token(Token = "0x600168B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E47208", Offset = "0x1E47208", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual PropertyDescriptor GetDefaultProperty()
		{
			throw null;
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x00006800 File Offset: 0x00004A00
		[global::Cpp2ILInjected.Token(Token = "0x600168C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E472B8", Offset = "0x1E472B8", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual object GetEditor(Type editorBaseType)
		{
			throw null;
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x00006803 File Offset: 0x00004A03
		[global::Cpp2ILInjected.Token(Token = "0x600168D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E47370", Offset = "0x1E47370", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual EventDescriptorCollection GetEvents()
		{
			throw null;
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x00006806 File Offset: 0x00004A06
		[global::Cpp2ILInjected.Token(Token = "0x600168E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4744C", Offset = "0x1E4744C", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual EventDescriptorCollection GetEvents(Attribute[] attributes)
		{
			throw null;
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x00006809 File Offset: 0x00004A09
		[global::Cpp2ILInjected.Token(Token = "0x600168F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E47530", Offset = "0x1E47530", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual PropertyDescriptorCollection GetProperties()
		{
			throw null;
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x0000680C File Offset: 0x00004A0C
		[global::Cpp2ILInjected.Token(Token = "0x6001690")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4760C", Offset = "0x1E4760C", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual PropertyDescriptorCollection GetProperties(Attribute[] attributes)
		{
			throw null;
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x0000680F File Offset: 0x00004A0F
		[global::Cpp2ILInjected.Token(Token = "0x6001691")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E476F0", Offset = "0x1E476F0", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual object GetPropertyOwner(PropertyDescriptor pd)
		{
			throw null;
		}

		// Token: 0x04000DE2 RID: 3554
		[global::Cpp2ILInjected.Token(Token = "0x40011E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly ICustomTypeDescriptor _parent;
	}
}
