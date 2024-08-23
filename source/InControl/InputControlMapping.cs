using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200001E RID: 30
	[global::Cpp2ILInjected.Token(Token = "0x200001F")]
	[Serializable]
	public class InputControlMapping
	{
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600013F RID: 319 RVA: 0x0000240B File Offset: 0x0000060B
		// (set) Token: 0x06000140 RID: 320 RVA: 0x0000240E File Offset: 0x0000060E
		[global::Cpp2ILInjected.Token(Token = "0x17000053")]
		public string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x600013F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1986394", Offset = "0x1986394", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDevice), Member = "Initialize", MemberParameters = new object[]
			{
				typeof(uint),
				typeof(InputDeviceInfo),
				typeof(InputDeviceProfile)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDevice), Member = "RefreshProfile", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDevice), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(InputDeviceProfile),
				typeof(int),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000140")]
			[global::Cpp2ILInjected.Address(RVA = "0x1986414", Offset = "0x1986414", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00002411 File Offset: 0x00000611
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00002414 File Offset: 0x00000614
		[global::Cpp2ILInjected.Token(Token = "0x17000054")]
		public bool Invert
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000141")]
			[global::Cpp2ILInjected.Address(RVA = "0x198641C", Offset = "0x198641C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000142")]
			[global::Cpp2ILInjected.Address(RVA = "0x1986424", Offset = "0x1986424", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00002417 File Offset: 0x00000617
		// (set) Token: 0x06000144 RID: 324 RVA: 0x0000241A File Offset: 0x0000061A
		[global::Cpp2ILInjected.Token(Token = "0x17000055")]
		public float Scale
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000143")]
			[global::Cpp2ILInjected.Address(RVA = "0x1986430", Offset = "0x1986430", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000144")]
			[global::Cpp2ILInjected.Address(RVA = "0x1986438", Offset = "0x1986438", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000145 RID: 325 RVA: 0x0000241D File Offset: 0x0000061D
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00002420 File Offset: 0x00000620
		[global::Cpp2ILInjected.Token(Token = "0x17000056")]
		public bool Raw
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000145")]
			[global::Cpp2ILInjected.Address(RVA = "0x1986440", Offset = "0x1986440", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000146")]
			[global::Cpp2ILInjected.Address(RVA = "0x1986448", Offset = "0x1986448", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00002423 File Offset: 0x00000623
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00002426 File Offset: 0x00000626
		[global::Cpp2ILInjected.Token(Token = "0x17000057")]
		public bool Passive
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000147")]
			[global::Cpp2ILInjected.Address(RVA = "0x1986454", Offset = "0x1986454", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000148")]
			[global::Cpp2ILInjected.Address(RVA = "0x198645C", Offset = "0x198645C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00002429 File Offset: 0x00000629
		// (set) Token: 0x0600014A RID: 330 RVA: 0x0000242C File Offset: 0x0000062C
		[global::Cpp2ILInjected.Token(Token = "0x17000058")]
		public bool IgnoreInitialZeroValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000149")]
			[global::Cpp2ILInjected.Address(RVA = "0x1986468", Offset = "0x1986468", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600014A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1986470", Offset = "0x1986470", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600014B RID: 331 RVA: 0x0000242F File Offset: 0x0000062F
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00002432 File Offset: 0x00000632
		[global::Cpp2ILInjected.Token(Token = "0x17000059")]
		public float Sensitivity
		{
			[global::Cpp2ILInjected.Token(Token = "0x600014B")]
			[global::Cpp2ILInjected.Address(RVA = "0x198647C", Offset = "0x198647C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600014C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1986484", Offset = "0x1986484", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00002435 File Offset: 0x00000635
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00002438 File Offset: 0x00000638
		[global::Cpp2ILInjected.Token(Token = "0x1700005A")]
		public float LowerDeadZone
		{
			[global::Cpp2ILInjected.Token(Token = "0x600014D")]
			[global::Cpp2ILInjected.Address(RVA = "0x19864A0", Offset = "0x19864A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600014E")]
			[global::Cpp2ILInjected.Address(RVA = "0x19864A8", Offset = "0x19864A8", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600014F RID: 335 RVA: 0x0000243B File Offset: 0x0000063B
		// (set) Token: 0x06000150 RID: 336 RVA: 0x0000243E File Offset: 0x0000063E
		[global::Cpp2ILInjected.Token(Token = "0x1700005B")]
		public float UpperDeadZone
		{
			[global::Cpp2ILInjected.Token(Token = "0x600014F")]
			[global::Cpp2ILInjected.Address(RVA = "0x19864C4", Offset = "0x19864C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000150")]
			[global::Cpp2ILInjected.Address(RVA = "0x19864CC", Offset = "0x19864CC", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00002441 File Offset: 0x00000641
		// (set) Token: 0x06000152 RID: 338 RVA: 0x00002444 File Offset: 0x00000644
		[global::Cpp2ILInjected.Token(Token = "0x1700005C")]
		public InputControlSource Source
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000151")]
			[global::Cpp2ILInjected.Address(RVA = "0x19864E8", Offset = "0x19864E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000152")]
			[global::Cpp2ILInjected.Address(RVA = "0x19864F0", Offset = "0x19864F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00002447 File Offset: 0x00000647
		// (set) Token: 0x06000154 RID: 340 RVA: 0x0000244A File Offset: 0x0000064A
		[global::Cpp2ILInjected.Token(Token = "0x1700005D")]
		public InputControlType Target
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000153")]
			[global::Cpp2ILInjected.Address(RVA = "0x19864F8", Offset = "0x19864F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000154")]
			[global::Cpp2ILInjected.Address(RVA = "0x1986500", Offset = "0x1986500", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000155 RID: 341 RVA: 0x0000244D File Offset: 0x0000064D
		// (set) Token: 0x06000156 RID: 342 RVA: 0x00002450 File Offset: 0x00000650
		[global::Cpp2ILInjected.Token(Token = "0x1700005E")]
		public InputRangeType SourceRange
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000155")]
			[global::Cpp2ILInjected.Address(RVA = "0x1986508", Offset = "0x1986508", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000156")]
			[global::Cpp2ILInjected.Address(RVA = "0x1986510", Offset = "0x1986510", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00002453 File Offset: 0x00000653
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00002456 File Offset: 0x00000656
		[global::Cpp2ILInjected.Token(Token = "0x1700005F")]
		public InputRangeType TargetRange
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000157")]
			[global::Cpp2ILInjected.Address(RVA = "0x1986518", Offset = "0x1986518", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000158")]
			[global::Cpp2ILInjected.Address(RVA = "0x1986520", Offset = "0x1986520", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002459 File Offset: 0x00000659
		[global::Cpp2ILInjected.Token(Token = "0x6000159")]
		[global::Cpp2ILInjected.Address(RVA = "0x1986528", Offset = "0x1986528", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDevice), Member = "Update", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDevice), Member = "Update", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputRange), Member = "Excludes", MemberParameters = new object[]
		{
			typeof(InputRangeType),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputRange), Member = "Remap", MemberParameters = new object[]
		{
			typeof(float),
			typeof(InputRangeType),
			typeof(InputRangeType)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public float ApplyToValue(float value)
		{
			throw null;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000245C File Offset: 0x0000065C
		[global::Cpp2ILInjected.Token(Token = "0x600015A")]
		[global::Cpp2ILInjected.Address(RVA = "0x19866B0", Offset = "0x19866B0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3458)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public InputControlMapping()
		{
			throw null;
		}

		// Token: 0x0400012A RID: 298
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400012E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string name;

		// Token: 0x0400012B RID: 299
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400012F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool invert;

		// Token: 0x0400012C RID: 300
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000130")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private float scale;

		// Token: 0x0400012D RID: 301
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000131")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool raw;

		// Token: 0x0400012E RID: 302
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000132")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
		private bool passive;

		// Token: 0x0400012F RID: 303
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000133")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x22")]
		private bool ignoreInitialZeroValue;

		// Token: 0x04000130 RID: 304
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000134")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private float sensitivity;

		// Token: 0x04000131 RID: 305
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000135")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private float lowerDeadZone;

		// Token: 0x04000132 RID: 306
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000136")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private float upperDeadZone;

		// Token: 0x04000133 RID: 307
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000137")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private InputControlSource source;

		// Token: 0x04000134 RID: 308
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000138")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private InputControlType target;

		// Token: 0x04000135 RID: 309
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000139")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private InputRangeType sourceRange;

		// Token: 0x04000136 RID: 310
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400013A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private InputRangeType targetRange;
	}
}
