using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002A2 RID: 674
	[global::Cpp2ILInjected.Token(Token = "0x200039A")]
	public class ListChangedEventArgs : EventArgs
	{
		// Token: 0x060015AA RID: 5546 RVA: 0x00006B36 File Offset: 0x00004D36
		[global::Cpp2ILInjected.Token(Token = "0x60017F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4F888", Offset = "0x1E4F888", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BindingList<>), Member = "FireListChanged", MemberParameters = new object[]
		{
			typeof(ListChangedType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JContainer", Member = "InsertItem", MemberParameters = new object[]
		{
			typeof(int),
			"Newtonsoft.Json.Linq.JToken",
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JContainer", Member = "RemoveItemAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JContainer", Member = "SetItem", MemberParameters = new object[]
		{
			typeof(int),
			"Newtonsoft.Json.Linq.JToken"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JContainer", Member = "ClearItems", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JObject", Member = "InternalPropertyChanged", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JProperty" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		public ListChangedEventArgs(ListChangedType listChangedType, int newIndex)
		{
			throw null;
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x00006B39 File Offset: 0x00004D39
		[global::Cpp2ILInjected.Token(Token = "0x60017F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4F910", Offset = "0x1E4F910", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BindingList<>), Member = "Child_PropertyChanged", MemberParameters = new object[]
		{
			typeof(object),
			typeof(PropertyChangedEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListChangedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ListChangedType),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public ListChangedEventArgs(ListChangedType listChangedType, int newIndex, PropertyDescriptor propDesc)
		{
			throw null;
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x00006B3C File Offset: 0x00004D3C
		[global::Cpp2ILInjected.Token(Token = "0x60017FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4F940", Offset = "0x1E4F940", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ListChangedEventArgs(ListChangedType listChangedType, PropertyDescriptor propDesc)
		{
			throw null;
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x00006B3F File Offset: 0x00004D3F
		[global::Cpp2ILInjected.Token(Token = "0x60017FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4F890", Offset = "0x1E4F890", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ListChangedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ListChangedType),
			typeof(int),
			typeof(PropertyDescriptor)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ListChangedEventArgs(ListChangedType listChangedType, int newIndex, int oldIndex)
		{
			throw null;
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x060015AE RID: 5550 RVA: 0x00006B42 File Offset: 0x00004D42
		[global::Cpp2ILInjected.Token(Token = "0x17000574")]
		public ListChangedType ListChangedType
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60017FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4F9B4", Offset = "0x1E4F9B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x060015AF RID: 5551 RVA: 0x00006B45 File Offset: 0x00004D45
		[global::Cpp2ILInjected.Token(Token = "0x17000575")]
		public int NewIndex
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60017FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4F9BC", Offset = "0x1E4F9BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x060015B0 RID: 5552 RVA: 0x00006B48 File Offset: 0x00004D48
		[global::Cpp2ILInjected.Token(Token = "0x17000576")]
		public int OldIndex
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60017FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4F9C4", Offset = "0x1E4F9C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x060015B1 RID: 5553 RVA: 0x00006B4B File Offset: 0x00004D4B
		[global::Cpp2ILInjected.Token(Token = "0x17000577")]
		public PropertyDescriptor PropertyDescriptor
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60017FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4F9CC", Offset = "0x1E4F9CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000E36 RID: 3638
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001240")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly ListChangedType <ListChangedType>k__BackingField;

		// Token: 0x04000E37 RID: 3639
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001241")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private readonly int <NewIndex>k__BackingField;

		// Token: 0x04000E38 RID: 3640
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001242")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly int <OldIndex>k__BackingField;

		// Token: 0x04000E39 RID: 3641
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001243")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly PropertyDescriptor <PropertyDescriptor>k__BackingField;
	}
}
