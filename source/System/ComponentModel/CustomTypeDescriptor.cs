using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x2000360")]
	public abstract class CustomTypeDescriptor : ICustomTypeDescriptor
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6001687")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E46F20", Offset = "0x1E46F20", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual string GetClassName()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001688")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E46FD0", Offset = "0x1E46FD0", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual string GetComponentName()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x600168A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E47158", Offset = "0x1E47158", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual EventDescriptor GetDefaultEvent()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600168B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E47208", Offset = "0x1E47208", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual PropertyDescriptor GetDefaultProperty()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600168C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E472B8", Offset = "0x1E472B8", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual object GetEditor(Type editorBaseType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600168D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E47370", Offset = "0x1E47370", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual EventDescriptorCollection GetEvents()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600168E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4744C", Offset = "0x1E4744C", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual EventDescriptorCollection GetEvents(Attribute[] attributes)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600168F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E47530", Offset = "0x1E47530", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual PropertyDescriptorCollection GetProperties()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001690")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4760C", Offset = "0x1E4760C", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual PropertyDescriptorCollection GetProperties(Attribute[] attributes)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001691")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E476F0", Offset = "0x1E476F0", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual object GetPropertyOwner(PropertyDescriptor pd)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40011E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly ICustomTypeDescriptor _parent;
	}
}
