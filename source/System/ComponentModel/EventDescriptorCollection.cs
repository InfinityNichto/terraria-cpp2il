﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x0200027E RID: 638
	[global::Cpp2ILInjected.Token(Token = "0x2000374")]
	public class EventDescriptorCollection : ICollection, IEnumerable, IList
	{
		// Token: 0x060014C9 RID: 5321 RVA: 0x0000697D File Offset: 0x00004B7D
		[global::Cpp2ILInjected.Token(Token = "0x6001710")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4AC2C", Offset = "0x1E4AC2C", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventDescriptorCollection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(EventDescriptor[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventDescriptorCollection), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public EventDescriptorCollection(EventDescriptor[] events)
		{
			throw null;
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x00006980 File Offset: 0x00004B80
		[global::Cpp2ILInjected.Token(Token = "0x6001711")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4ACDC", Offset = "0x1E4ACDC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData", Member = "GetEvents", ReturnType = typeof(EventDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(EventDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Attribute[])
		}, ReturnType = typeof(EventDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Attribute[]),
			typeof(bool)
		}, ReturnType = typeof(EventDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineAttributeFilter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ICollection),
			typeof(Attribute[]),
			typeof(object),
			typeof(IDictionary)
		}, ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ICollection),
			typeof(object),
			typeof(IDictionary)
		}, ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineMerge", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ICollection),
			typeof(ICollection),
			typeof(object),
			typeof(IDictionary)
		}, ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventDescriptorCollection), Member = ".ctor", MemberParameters = new object[] { typeof(EventDescriptor[]) }, ReturnType = typeof(void))]
		public EventDescriptorCollection(EventDescriptor[] events, bool readOnly)
		{
			throw null;
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x00006983 File Offset: 0x00004B83
		[global::Cpp2ILInjected.Token(Token = "0x6001712")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4AD00", Offset = "0x1E4AD00", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventDescriptorCollection), Member = "Sort", ReturnType = typeof(EventDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventDescriptorCollection), Member = "Sort", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(EventDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventDescriptorCollection), Member = "Sort", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(IComparer)
		}, ReturnType = typeof(EventDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventDescriptorCollection), Member = "Sort", MemberParameters = new object[] { typeof(IComparer) }, ReturnType = typeof(EventDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private EventDescriptorCollection(EventDescriptor[] events, int eventCount, string[] namedSort, IComparer comparer)
		{
			throw null;
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x060014CC RID: 5324 RVA: 0x00006986 File Offset: 0x00004B86
		// (set) Token: 0x060014CD RID: 5325 RVA: 0x00006989 File Offset: 0x00004B89
		[global::Cpp2ILInjected.Token(Token = "0x1700053D")]
		public int Count
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001713")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4ADD4", Offset = "0x1E4ADD4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001714")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4ADDC", Offset = "0x1E4ADDC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000515 RID: 1301
		[global::Cpp2ILInjected.Token(Token = "0x1700053E")]
		public virtual EventDescriptor this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001715")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4ADE4", Offset = "0x1E4ADE4", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventDescriptorCollection), Member = "EnsureEventsOwned", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000516 RID: 1302
		[global::Cpp2ILInjected.Token(Token = "0x1700053F")]
		public virtual EventDescriptor this[string name]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001716")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4AEFC", Offset = "0x1E4AEFC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x00006992 File Offset: 0x00004B92
		[global::Cpp2ILInjected.Token(Token = "0x6001717")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4AF10", Offset = "0x1E4AF10", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventDescriptorCollection), Member = "System.Collections.IList.Add", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventDescriptorCollection), Member = "EnsureSize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public int Add(EventDescriptor value)
		{
			throw null;
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x00006995 File Offset: 0x00004B95
		[global::Cpp2ILInjected.Token(Token = "0x6001718")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4B0B4", Offset = "0x1E4B0B4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventDescriptorCollection), Member = "System.Collections.IList.Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x00006998 File Offset: 0x00004B98
		[global::Cpp2ILInjected.Token(Token = "0x6001719")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4B100", Offset = "0x1E4B100", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventDescriptorCollection), Member = "IndexOf", MemberParameters = new object[] { typeof(EventDescriptor) }, ReturnType = typeof(int))]
		public bool Contains(EventDescriptor value)
		{
			throw null;
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x0000699B File Offset: 0x00004B9B
		[global::Cpp2ILInjected.Token(Token = "0x600171A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4B178", Offset = "0x1E4B178", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventDescriptorCollection), Member = "EnsureEventsOwned", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		private void System.Collections.ICollection.CopyTo(Array array, int index)
		{
			throw null;
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x0000699E File Offset: 0x00004B9E
		[global::Cpp2ILInjected.Token(Token = "0x600171B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4AE50", Offset = "0x1E4AE50", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventDescriptorCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(EventDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventDescriptorCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventDescriptorCollection), Member = "EnsureSize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventDescriptorCollection), Member = "System.Collections.IList.set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventDescriptorCollection), Member = "InternalSort", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void EnsureEventsOwned()
		{
			throw null;
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x000069A1 File Offset: 0x00004BA1
		[global::Cpp2ILInjected.Token(Token = "0x600171C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4AFC0", Offset = "0x1E4AFC0", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventDescriptorCollection), Member = "Add", MemberParameters = new object[] { typeof(EventDescriptor) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventDescriptorCollection), Member = "Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(EventDescriptor)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventDescriptorCollection), Member = "EnsureEventsOwned", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void EnsureSize(int sizeNeeded)
		{
			throw null;
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x000069A4 File Offset: 0x00004BA4
		[global::Cpp2ILInjected.Token(Token = "0x600171D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4B3CC", Offset = "0x1E4B3CC", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		public virtual EventDescriptor Find(string name, bool ignoreCase)
		{
			throw null;
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x000069A7 File Offset: 0x00004BA7
		[global::Cpp2ILInjected.Token(Token = "0x600171E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4B118", Offset = "0x1E4B118", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventDescriptorCollection), Member = "Contains", MemberParameters = new object[] { typeof(EventDescriptor) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventDescriptorCollection), Member = "Remove", MemberParameters = new object[] { typeof(EventDescriptor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventDescriptorCollection), Member = "System.Collections.IList.Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventDescriptorCollection), Member = "System.Collections.IList.IndexOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "IndexOf", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(object),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public int IndexOf(EventDescriptor value)
		{
			throw null;
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x000069AA File Offset: 0x00004BAA
		[global::Cpp2ILInjected.Token(Token = "0x600171F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4B490", Offset = "0x1E4B490", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventDescriptorCollection), Member = "System.Collections.IList.Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventDescriptorCollection), Member = "EnsureSize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void Insert(int index, EventDescriptor value)
		{
			throw null;
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x000069AD File Offset: 0x00004BAD
		[global::Cpp2ILInjected.Token(Token = "0x6001720")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4B560", Offset = "0x1E4B560", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventDescriptorCollection), Member = "System.Collections.IList.Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventDescriptorCollection), Member = "IndexOf", MemberParameters = new object[] { typeof(EventDescriptor) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Remove(EventDescriptor value)
		{
			throw null;
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x000069B0 File Offset: 0x00004BB0
		[global::Cpp2ILInjected.Token(Token = "0x6001721")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4B5C8", Offset = "0x1E4B5C8", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventDescriptorCollection), Member = "System.Collections.IList.RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void RemoveAt(int index)
		{
			throw null;
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x000069B3 File Offset: 0x00004BB3
		[global::Cpp2ILInjected.Token(Token = "0x6001722")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4B65C", Offset = "0x1E4B65C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventDescriptorCollection), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public IEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x000069B6 File Offset: 0x00004BB6
		[global::Cpp2ILInjected.Token(Token = "0x6001723")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4B71C", Offset = "0x1E4B71C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventDescriptorCollection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(EventDescriptor[]),
			typeof(int),
			typeof(string[]),
			typeof(IComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual EventDescriptorCollection Sort()
		{
			throw null;
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x000069B9 File Offset: 0x00004BB9
		[global::Cpp2ILInjected.Token(Token = "0x6001724")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4B794", Offset = "0x1E4B794", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventDescriptorCollection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(EventDescriptor[]),
			typeof(int),
			typeof(string[]),
			typeof(IComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual EventDescriptorCollection Sort(string[] names)
		{
			throw null;
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x000069BC File Offset: 0x00004BBC
		[global::Cpp2ILInjected.Token(Token = "0x6001725")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4B810", Offset = "0x1E4B810", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventDescriptorCollection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(EventDescriptor[]),
			typeof(int),
			typeof(string[]),
			typeof(IComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual EventDescriptorCollection Sort(string[] names, IComparer comparer)
		{
			throw null;
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x000069BF File Offset: 0x00004BBF
		[global::Cpp2ILInjected.Token(Token = "0x6001726")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4B88C", Offset = "0x1E4B88C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventDescriptorCollection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(EventDescriptor[]),
			typeof(int),
			typeof(string[]),
			typeof(IComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual EventDescriptorCollection Sort(IComparer comparer)
		{
			throw null;
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x000069C2 File Offset: 0x00004BC2
		[global::Cpp2ILInjected.Token(Token = "0x6001727")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4B1B4", Offset = "0x1E4B1B4", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventDescriptorCollection), Member = "EnsureEventsOwned", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventDescriptorCollection), Member = "InternalSort", MemberParameters = new object[] { typeof(IComparer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		protected void InternalSort(string[] names)
		{
			throw null;
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x000069C5 File Offset: 0x00004BC5
		[global::Cpp2ILInjected.Token(Token = "0x6001728")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4B908", Offset = "0x1E4B908", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventDescriptorCollection), Member = "InternalSort", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Sort", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(IComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "SortDescriptorArray", MemberParameters = new object[] { typeof(IList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected void InternalSort(IComparer sorter)
		{
			throw null;
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x060014E2 RID: 5346 RVA: 0x000069C8 File Offset: 0x00004BC8
		[global::Cpp2ILInjected.Token(Token = "0x17000540")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001729")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4B980", Offset = "0x1E4B980", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x060014E3 RID: 5347 RVA: 0x000069CB File Offset: 0x00004BCB
		[global::Cpp2ILInjected.Token(Token = "0x17000541")]
		private object System.Collections.ICollection.SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x600172A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4B988", Offset = "0x1E4B988", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x060014E4 RID: 5348 RVA: 0x000069CE File Offset: 0x00004BCE
		[global::Cpp2ILInjected.Token(Token = "0x17000542")]
		private int System.Collections.ICollection.Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x600172B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4B990", Offset = "0x1E4B990", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x000069D1 File Offset: 0x00004BD1
		[global::Cpp2ILInjected.Token(Token = "0x600172C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4B998", Offset = "0x1E4B998", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventDescriptorCollection), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x060014E6 RID: 5350 RVA: 0x000069D4 File Offset: 0x00004BD4
		// (set) Token: 0x060014E7 RID: 5351 RVA: 0x000069D7 File Offset: 0x00004BD7
		[global::Cpp2ILInjected.Token(Token = "0x17000543")]
		private object System.Collections.IList.Item
		{
			[global::Cpp2ILInjected.Token(Token = "0x600172D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4B99C", Offset = "0x1E4B99C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600172E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4B9AC", Offset = "0x1E4B9AC", Length = "0x150")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventDescriptorCollection), Member = "EnsureEventsOwned", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x000069DA File Offset: 0x00004BDA
		[global::Cpp2ILInjected.Token(Token = "0x600172F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4BAFC", Offset = "0x1E4BAFC", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventDescriptorCollection), Member = "Add", MemberParameters = new object[] { typeof(EventDescriptor) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private int System.Collections.IList.Add(object value)
		{
			throw null;
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x000069DD File Offset: 0x00004BDD
		[global::Cpp2ILInjected.Token(Token = "0x6001730")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4BB80", Offset = "0x1E4BB80", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventDescriptorCollection), Member = "IndexOf", MemberParameters = new object[] { typeof(EventDescriptor) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool System.Collections.IList.Contains(object value)
		{
			throw null;
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x000069E0 File Offset: 0x00004BE0
		[global::Cpp2ILInjected.Token(Token = "0x6001731")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4BC10", Offset = "0x1E4BC10", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventDescriptorCollection), Member = "Clear", ReturnType = typeof(void))]
		private void System.Collections.IList.Clear()
		{
			throw null;
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x000069E3 File Offset: 0x00004BE3
		[global::Cpp2ILInjected.Token(Token = "0x6001732")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4BC14", Offset = "0x1E4BC14", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventDescriptorCollection), Member = "IndexOf", MemberParameters = new object[] { typeof(EventDescriptor) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private int System.Collections.IList.IndexOf(object value)
		{
			throw null;
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x000069E6 File Offset: 0x00004BE6
		[global::Cpp2ILInjected.Token(Token = "0x6001733")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4BC98", Offset = "0x1E4BC98", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventDescriptorCollection), Member = "Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(EventDescriptor)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void System.Collections.IList.Insert(int index, object value)
		{
			throw null;
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x000069E9 File Offset: 0x00004BE9
		[global::Cpp2ILInjected.Token(Token = "0x6001734")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4BD2C", Offset = "0x1E4BD2C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventDescriptorCollection), Member = "Remove", MemberParameters = new object[] { typeof(EventDescriptor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void System.Collections.IList.Remove(object value)
		{
			throw null;
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x000069EC File Offset: 0x00004BEC
		[global::Cpp2ILInjected.Token(Token = "0x6001735")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4BDB0", Offset = "0x1E4BDB0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventDescriptorCollection), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		private void System.Collections.IList.RemoveAt(int index)
		{
			throw null;
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x060014EF RID: 5359 RVA: 0x000069EF File Offset: 0x00004BEF
		[global::Cpp2ILInjected.Token(Token = "0x17000544")]
		private bool System.Collections.IList.IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001736")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4BDB4", Offset = "0x1E4BDB4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x060014F0 RID: 5360 RVA: 0x000069F2 File Offset: 0x00004BF2
		[global::Cpp2ILInjected.Token(Token = "0x17000545")]
		private bool System.Collections.IList.IsFixedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001737")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4BDBC", Offset = "0x1E4BDBC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x000069F5 File Offset: 0x00004BF5
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001738")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4BDC4", Offset = "0x1E4BDC4", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventDescriptorCollection), Member = ".ctor", MemberParameters = new object[] { typeof(EventDescriptor[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static EventDescriptorCollection()
		{
			throw null;
		}

		// Token: 0x04000E16 RID: 3606
		[global::Cpp2ILInjected.Token(Token = "0x400121B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private EventDescriptor[] _events;

		// Token: 0x04000E17 RID: 3607
		[global::Cpp2ILInjected.Token(Token = "0x400121C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string[] _namedSort;

		// Token: 0x04000E18 RID: 3608
		[global::Cpp2ILInjected.Token(Token = "0x400121D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly IComparer _comparer;

		// Token: 0x04000E19 RID: 3609
		[global::Cpp2ILInjected.Token(Token = "0x400121E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool _eventsOwned;

		// Token: 0x04000E1A RID: 3610
		[global::Cpp2ILInjected.Token(Token = "0x400121F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		private bool _needSort;

		// Token: 0x04000E1B RID: 3611
		[global::Cpp2ILInjected.Token(Token = "0x4001220")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A")]
		private readonly bool _readOnly;

		// Token: 0x04000E1C RID: 3612
		[global::Cpp2ILInjected.Token(Token = "0x4001221")]
		public static readonly EventDescriptorCollection Empty;

		// Token: 0x04000E1D RID: 3613
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001222")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private int <Count>k__BackingField;

		// Token: 0x02000458 RID: 1112
		[global::Cpp2ILInjected.Token(Token = "0x2000375")]
		private class ArraySubsetEnumerator : IEnumerator
		{
			// Token: 0x06001EDD RID: 7901 RVA: 0x00008516 File Offset: 0x00006716
			[global::Cpp2ILInjected.Token(Token = "0x6001739")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4B6E8", Offset = "0x1E4B6E8", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ArraySubsetEnumerator(Array array, int count)
			{
				throw null;
			}

			// Token: 0x06001EDE RID: 7902 RVA: 0x00008519 File Offset: 0x00006719
			[global::Cpp2ILInjected.Token(Token = "0x600173A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4BE28", Offset = "0x1E4BE28", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool MoveNext()
			{
				throw null;
			}

			// Token: 0x06001EDF RID: 7903 RVA: 0x0000851C File Offset: 0x0000671C
			[global::Cpp2ILInjected.Token(Token = "0x600173B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4BE50", Offset = "0x1E4BE50", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Reset()
			{
				throw null;
			}

			// Token: 0x1700074C RID: 1868
			// (get) Token: 0x06001EE0 RID: 7904 RVA: 0x0000851F File Offset: 0x0000671F
			[global::Cpp2ILInjected.Token(Token = "0x17000546")]
			public object Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x600173C")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E4BE5C", Offset = "0x1E4BE5C", Length = "0x54")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				get
				{
					throw null;
				}
			}

			// Token: 0x04001389 RID: 5001
			[global::Cpp2ILInjected.Token(Token = "0x4001223")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private readonly Array _array;

			// Token: 0x0400138A RID: 5002
			[global::Cpp2ILInjected.Token(Token = "0x4001224")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private readonly int _total;

			// Token: 0x0400138B RID: 5003
			[global::Cpp2ILInjected.Token(Token = "0x4001225")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private int _current;
		}
	}
}