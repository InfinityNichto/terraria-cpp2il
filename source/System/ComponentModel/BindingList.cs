using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x0200025E RID: 606
	[global::Cpp2ILInjected.Token(Token = "0x2000352")]
	[Serializable]
	public class BindingList<T> : Collection<T>, IBindingList, IList, ICollection, IEnumerable, ICancelAddNew, IRaiseItemChangedEvents
	{
		// Token: 0x060013CE RID: 5070 RVA: 0x000066B3 File Offset: 0x000048B3
		[global::Cpp2ILInjected.Token(Token = "0x6001610")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E6130", Offset = "0x18E6130", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public BindingList()
		{
			throw null;
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x000066B6 File Offset: 0x000048B6
		[global::Cpp2ILInjected.Token(Token = "0x6001611")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E6194", Offset = "0x18E6194", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public BindingList(IList<T> list)
		{
			throw null;
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x000066B9 File Offset: 0x000048B9
		[global::Cpp2ILInjected.Token(Token = "0x6001612")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E61F8", Offset = "0x18E61F8", Length = "0x3A4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private void Initialize()
		{
			throw null;
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x060013D1 RID: 5073 RVA: 0x000066BC File Offset: 0x000048BC
		[global::Cpp2ILInjected.Token(Token = "0x17000504")]
		private bool ItemTypeHasDefaultConstructor
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001613")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E659C", Offset = "0x18E659C", Length = "0x12C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new object[]
			{
				typeof(BindingFlags),
				typeof(Binder),
				typeof(Type[]),
				typeof(ParameterModifier[])
			}, ReturnType = typeof(ConstructorInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConstructorInfo), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(ConstructorInfo),
				typeof(ConstructorInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060013D2 RID: 5074 RVA: 0x000066BF File Offset: 0x000048BF
		// (remove) Token: 0x060013D3 RID: 5075 RVA: 0x000066C2 File Offset: 0x000048C2
		[global::Cpp2ILInjected.Token(Token = "0x14000011")]
		public event AddingNewEventHandler AddingNew
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001614")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E66C8", Offset = "0x18E66C8", Length = "0xF8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001615")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E67C0", Offset = "0x18E67C0", Length = "0xF8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x000066C5 File Offset: 0x000048C5
		[global::Cpp2ILInjected.Token(Token = "0x6001616")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E68B8", Offset = "0x18E68B8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnAddingNew(AddingNewEventArgs e)
		{
			throw null;
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x000066C8 File Offset: 0x000048C8
		[global::Cpp2ILInjected.Token(Token = "0x6001617")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E68E0", Offset = "0x18E68E0", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AddingNewEventArgs), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private object FireAddingNew()
		{
			throw null;
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060013D6 RID: 5078 RVA: 0x000066CB File Offset: 0x000048CB
		// (remove) Token: 0x060013D7 RID: 5079 RVA: 0x000066CE File Offset: 0x000048CE
		[global::Cpp2ILInjected.Token(Token = "0x14000012")]
		public event ListChangedEventHandler ListChanged
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001618")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E6954", Offset = "0x18E6954", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			add
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001619")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E69D4", Offset = "0x18E69D4", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x000066D1 File Offset: 0x000048D1
		[global::Cpp2ILInjected.Token(Token = "0x600161A")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E6A54", Offset = "0x18E6A54", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnListChanged(ListChangedEventArgs e)
		{
			throw null;
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x060013D9 RID: 5081 RVA: 0x000066D4 File Offset: 0x000048D4
		// (set) Token: 0x060013DA RID: 5082 RVA: 0x000066D7 File Offset: 0x000048D7
		[global::Cpp2ILInjected.Token(Token = "0x17000505")]
		public bool RaiseListChangedEvents
		{
			[global::Cpp2ILInjected.Token(Token = "0x600161B")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E6A7C", Offset = "0x18E6A7C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600161C")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E6A84", Offset = "0x18E6A84", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x000066DA File Offset: 0x000048DA
		[global::Cpp2ILInjected.Token(Token = "0x600161D")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E6A90", Offset = "0x18E6A90", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void ResetBindings()
		{
			throw null;
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x000066DD File Offset: 0x000048DD
		[global::Cpp2ILInjected.Token(Token = "0x600161E")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E6AAC", Offset = "0x18E6AAC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void ResetItem(int position)
		{
			throw null;
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x000066E0 File Offset: 0x000048E0
		[global::Cpp2ILInjected.Token(Token = "0x600161F")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E6AC8", Offset = "0x18E6AC8", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListChangedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ListChangedType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void FireListChanged(ListChangedType type, int index)
		{
			throw null;
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x000066E3 File Offset: 0x000048E3
		[global::Cpp2ILInjected.Token(Token = "0x6001620")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E6B60", Offset = "0x18E6B60", Length = "0x358")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		protected override void ClearItems()
		{
			throw null;
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x000066E6 File Offset: 0x000048E6
		[global::Cpp2ILInjected.Token(Token = "0x6001621")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E6EB8", Offset = "0x18E6EB8", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override void InsertItem(int index, T item)
		{
			throw null;
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x000066E9 File Offset: 0x000048E9
		[global::Cpp2ILInjected.Token(Token = "0x6001622")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E6F5C", Offset = "0x18E6F5C", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected override void RemoveItem(int index)
		{
			throw null;
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x000066EC File Offset: 0x000048EC
		[global::Cpp2ILInjected.Token(Token = "0x6001623")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E705C", Offset = "0x18E705C", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override void SetItem(int index, T item)
		{
			throw null;
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x000066EF File Offset: 0x000048EF
		[global::Cpp2ILInjected.Token(Token = "0x6001624")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E7128", Offset = "0x18E7128", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void CancelNew(int itemIndex)
		{
			throw null;
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x000066F2 File Offset: 0x000048F2
		[global::Cpp2ILInjected.Token(Token = "0x6001625")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E7160", Offset = "0x18E7160", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void EndNew(int itemIndex)
		{
			throw null;
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x000066F5 File Offset: 0x000048F5
		[global::Cpp2ILInjected.Token(Token = "0x6001626")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E717C", Offset = "0x18E717C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public T AddNew()
		{
			throw null;
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x000066F8 File Offset: 0x000048F8
		[global::Cpp2ILInjected.Token(Token = "0x6001627")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E726C", Offset = "0x18E726C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private object System.ComponentModel.IBindingList.AddNew()
		{
			throw null;
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x060013E6 RID: 5094 RVA: 0x000066FB File Offset: 0x000048FB
		[global::Cpp2ILInjected.Token(Token = "0x17000506")]
		private bool AddingNewHandled
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001628")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E7318", Offset = "0x18E7318", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x000066FE File Offset: 0x000048FE
		[global::Cpp2ILInjected.Token(Token = "0x6001629")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E7344", Offset = "0x18E7344", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityUtils), Member = "SecureCreateInstance", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected virtual object AddNewCore()
		{
			throw null;
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x00006701 File Offset: 0x00004901
		// (set) Token: 0x060013E9 RID: 5097 RVA: 0x00006704 File Offset: 0x00004904
		[global::Cpp2ILInjected.Token(Token = "0x17000507")]
		public bool AllowNew
		{
			[global::Cpp2ILInjected.Token(Token = "0x600162A")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E744C", Offset = "0x18E744C", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600162B")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E7480", Offset = "0x18E7480", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x060013EA RID: 5098 RVA: 0x00006707 File Offset: 0x00004907
		[global::Cpp2ILInjected.Token(Token = "0x17000508")]
		private bool System.ComponentModel.IBindingList.AllowNew
		{
			[global::Cpp2ILInjected.Token(Token = "0x600162C")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E7500", Offset = "0x18E7500", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060013EB RID: 5099 RVA: 0x0000670A File Offset: 0x0000490A
		// (set) Token: 0x060013EC RID: 5100 RVA: 0x0000670D File Offset: 0x0000490D
		[global::Cpp2ILInjected.Token(Token = "0x17000509")]
		public bool AllowEdit
		{
			[global::Cpp2ILInjected.Token(Token = "0x600162D")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E7514", Offset = "0x18E7514", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600162E")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E751C", Offset = "0x18E751C", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060013ED RID: 5101 RVA: 0x00006710 File Offset: 0x00004910
		[global::Cpp2ILInjected.Token(Token = "0x1700050A")]
		private bool System.ComponentModel.IBindingList.AllowEdit
		{
			[global::Cpp2ILInjected.Token(Token = "0x600162F")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E7550", Offset = "0x18E7550", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x060013EE RID: 5102 RVA: 0x00006713 File Offset: 0x00004913
		// (set) Token: 0x060013EF RID: 5103 RVA: 0x00006716 File Offset: 0x00004916
		[global::Cpp2ILInjected.Token(Token = "0x1700050B")]
		public bool AllowRemove
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001630")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E7564", Offset = "0x18E7564", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001631")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E756C", Offset = "0x18E756C", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x060013F0 RID: 5104 RVA: 0x00006719 File Offset: 0x00004919
		[global::Cpp2ILInjected.Token(Token = "0x1700050C")]
		private bool System.ComponentModel.IBindingList.AllowRemove
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001632")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E75A0", Offset = "0x18E75A0", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x060013F1 RID: 5105 RVA: 0x0000671C File Offset: 0x0000491C
		[global::Cpp2ILInjected.Token(Token = "0x1700050D")]
		private bool System.ComponentModel.IBindingList.SupportsChangeNotification
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001633")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E75B4", Offset = "0x18E75B4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x060013F2 RID: 5106 RVA: 0x0000671F File Offset: 0x0000491F
		[global::Cpp2ILInjected.Token(Token = "0x1700050E")]
		protected virtual bool SupportsChangeNotificationCore
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001634")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E75C4", Offset = "0x18E75C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x060013F3 RID: 5107 RVA: 0x00006722 File Offset: 0x00004922
		[global::Cpp2ILInjected.Token(Token = "0x1700050F")]
		private bool System.ComponentModel.IBindingList.SupportsSearching
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001635")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E75CC", Offset = "0x18E75CC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x060013F4 RID: 5108 RVA: 0x00006725 File Offset: 0x00004925
		[global::Cpp2ILInjected.Token(Token = "0x17000510")]
		protected virtual bool SupportsSearchingCore
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001636")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E75DC", Offset = "0x18E75DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x060013F5 RID: 5109 RVA: 0x00006728 File Offset: 0x00004928
		[global::Cpp2ILInjected.Token(Token = "0x17000511")]
		private bool System.ComponentModel.IBindingList.SupportsSorting
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001637")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E75E4", Offset = "0x18E75E4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x0000672B File Offset: 0x0000492B
		[global::Cpp2ILInjected.Token(Token = "0x17000512")]
		protected virtual bool SupportsSortingCore
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001638")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E75F4", Offset = "0x18E75F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x060013F7 RID: 5111 RVA: 0x0000672E File Offset: 0x0000492E
		[global::Cpp2ILInjected.Token(Token = "0x17000513")]
		private bool System.ComponentModel.IBindingList.IsSorted
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001639")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E75FC", Offset = "0x18E75FC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x060013F8 RID: 5112 RVA: 0x00006731 File Offset: 0x00004931
		[global::Cpp2ILInjected.Token(Token = "0x17000514")]
		protected virtual bool IsSortedCore
		{
			[global::Cpp2ILInjected.Token(Token = "0x600163A")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E760C", Offset = "0x18E760C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x060013F9 RID: 5113 RVA: 0x00006734 File Offset: 0x00004934
		[global::Cpp2ILInjected.Token(Token = "0x17000515")]
		private PropertyDescriptor System.ComponentModel.IBindingList.SortProperty
		{
			[global::Cpp2ILInjected.Token(Token = "0x600163B")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E7614", Offset = "0x18E7614", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x060013FA RID: 5114 RVA: 0x00006737 File Offset: 0x00004937
		[global::Cpp2ILInjected.Token(Token = "0x17000516")]
		protected virtual PropertyDescriptor SortPropertyCore
		{
			[global::Cpp2ILInjected.Token(Token = "0x600163C")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E7624", Offset = "0x18E7624", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x0000673A File Offset: 0x0000493A
		[global::Cpp2ILInjected.Token(Token = "0x17000517")]
		private ListSortDirection System.ComponentModel.IBindingList.SortDirection
		{
			[global::Cpp2ILInjected.Token(Token = "0x600163D")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E762C", Offset = "0x18E762C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x060013FC RID: 5116 RVA: 0x0000673D File Offset: 0x0000493D
		[global::Cpp2ILInjected.Token(Token = "0x17000518")]
		protected virtual ListSortDirection SortDirectionCore
		{
			[global::Cpp2ILInjected.Token(Token = "0x600163E")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E763C", Offset = "0x18E763C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x00006740 File Offset: 0x00004940
		[global::Cpp2ILInjected.Token(Token = "0x600163F")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E7644", Offset = "0x18E7644", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor prop, ListSortDirection direction)
		{
			throw null;
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x00006743 File Offset: 0x00004943
		[global::Cpp2ILInjected.Token(Token = "0x6001640")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E7654", Offset = "0x18E7654", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected virtual void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
		{
			throw null;
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x00006746 File Offset: 0x00004946
		[global::Cpp2ILInjected.Token(Token = "0x6001641")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E768C", Offset = "0x18E768C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.ComponentModel.IBindingList.RemoveSort()
		{
			throw null;
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x00006749 File Offset: 0x00004949
		[global::Cpp2ILInjected.Token(Token = "0x6001642")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E769C", Offset = "0x18E769C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected virtual void RemoveSortCore()
		{
			throw null;
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x0000674C File Offset: 0x0000494C
		[global::Cpp2ILInjected.Token(Token = "0x6001643")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E76D4", Offset = "0x18E76D4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private int System.ComponentModel.IBindingList.Find(PropertyDescriptor prop, object key)
		{
			throw null;
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x0000674F File Offset: 0x0000494F
		[global::Cpp2ILInjected.Token(Token = "0x6001644")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E76E4", Offset = "0x18E76E4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected virtual int FindCore(PropertyDescriptor prop, object key)
		{
			throw null;
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x00006752 File Offset: 0x00004952
		[global::Cpp2ILInjected.Token(Token = "0x6001645")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E771C", Offset = "0x18E771C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor prop)
		{
			throw null;
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x00006755 File Offset: 0x00004955
		[global::Cpp2ILInjected.Token(Token = "0x6001646")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E7720", Offset = "0x18E7720", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor prop)
		{
			throw null;
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x00006758 File Offset: 0x00004958
		[global::Cpp2ILInjected.Token(Token = "0x6001647")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E7724", Offset = "0x18E7724", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyChangedEventHandler), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void HookPropertyChanged(T item)
		{
			throw null;
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x0000675B File Offset: 0x0000495B
		[global::Cpp2ILInjected.Token(Token = "0x6001648")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E7834", Offset = "0x18E7834", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void UnhookPropertyChanged(T item)
		{
			throw null;
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x0000675E File Offset: 0x0000495E
		[global::Cpp2ILInjected.Token(Token = "0x6001649")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E7908", Offset = "0x18E7908", Length = "0x314")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListChangedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ListChangedType),
			typeof(int),
			typeof(PropertyDescriptor)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		private void Child_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			throw null;
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06001408 RID: 5128 RVA: 0x00006761 File Offset: 0x00004961
		[global::Cpp2ILInjected.Token(Token = "0x17000519")]
		private bool System.ComponentModel.IRaiseItemChangedEvents.RaisesItemChangedEvents
		{
			[global::Cpp2ILInjected.Token(Token = "0x600164A")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E7C1C", Offset = "0x18E7C1C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000DC8 RID: 3528
		[global::Cpp2ILInjected.Token(Token = "0x40011CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int addNewPos;

		// Token: 0x04000DC9 RID: 3529
		[global::Cpp2ILInjected.Token(Token = "0x40011CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool raiseListChangedEvents;

		// Token: 0x04000DCA RID: 3530
		[global::Cpp2ILInjected.Token(Token = "0x40011CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool raiseItemChangedEvents;

		// Token: 0x04000DCB RID: 3531
		[global::Cpp2ILInjected.Token(Token = "0x40011CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private PropertyDescriptorCollection _itemTypeProperties;

		// Token: 0x04000DCC RID: 3532
		[global::Cpp2ILInjected.Token(Token = "0x40011CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private PropertyChangedEventHandler _propertyChangedEventHandler;

		// Token: 0x04000DCD RID: 3533
		[global::Cpp2ILInjected.Token(Token = "0x40011D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private AddingNewEventHandler _onAddingNew;

		// Token: 0x04000DCE RID: 3534
		[global::Cpp2ILInjected.Token(Token = "0x40011D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private ListChangedEventHandler _onListChanged;

		// Token: 0x04000DCF RID: 3535
		[global::Cpp2ILInjected.Token(Token = "0x40011D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private int _lastChangeIndex;

		// Token: 0x04000DD0 RID: 3536
		[global::Cpp2ILInjected.Token(Token = "0x40011D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool allowNew;

		// Token: 0x04000DD1 RID: 3537
		[global::Cpp2ILInjected.Token(Token = "0x40011D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool allowEdit;

		// Token: 0x04000DD2 RID: 3538
		[global::Cpp2ILInjected.Token(Token = "0x40011D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool allowRemove;

		// Token: 0x04000DD3 RID: 3539
		[global::Cpp2ILInjected.Token(Token = "0x40011D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool userSetAllowNew;
	}
}
