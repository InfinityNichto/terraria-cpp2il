using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;
using Terraria.UI.Chat;
using Terraria.Utilities;
using UnityEngine;

namespace Terraria.GameContent.UI
{
	// Token: 0x0200069C RID: 1692
	[global::Cpp2ILInjected.Token(Token = "0x2000A5E")]
	public class GameTipsDisplay
	{
		// Token: 0x0600427E RID: 17022 RVA: 0x0002DE30 File Offset: 0x0002C030
		[global::Cpp2ILInjected.Token(Token = "0x6004E76")]
		[global::Cpp2ILInjected.Address(RVA = "0x8E1D70", Offset = "0x8E1D70", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public GameTipsDisplay()
		{
			throw null;
		}

		// Token: 0x0600427F RID: 17023 RVA: 0x0002DE33 File Offset: 0x0002C033
		[global::Cpp2ILInjected.Token(Token = "0x6004E77")]
		[global::Cpp2ILInjected.Address(RVA = "0x8E1DF4", Offset = "0x8E1DF4", Length = "0x310")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerAndGameModeMismatch), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIStatusMenu), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldGenerateMenu), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Predicate<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAll", MemberParameters = new object[] { typeof(Predicate<object>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameTipsDisplay), Member = "AddNewTip", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameTipsDisplay.GameTip), Member = "Update", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public void Update()
		{
			throw null;
		}

		// Token: 0x06004280 RID: 17024 RVA: 0x0002DE36 File Offset: 0x0002C036
		[global::Cpp2ILInjected.Token(Token = "0x6004E78")]
		[global::Cpp2ILInjected.Address(RVA = "0x8E24D4", Offset = "0x8E24D4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void ClearTips()
		{
			throw null;
		}

		// Token: 0x06004281 RID: 17025 RVA: 0x0002DE39 File Offset: 0x0002C039
		[global::Cpp2ILInjected.Token(Token = "0x6004E79")]
		[global::Cpp2ILInjected.Address(RVA = "0x8E253C", Offset = "0x8E253C", Length = "0x920")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerAndGameModeMismatch), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIStatusMenu), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldGenerateMenu), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Clear", ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "GetRegion", MemberParameters = new object[]
		{
			typeof(String_Layout),
			typeof(string)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(String_Layout), Member = "GetFont", ReturnType = typeof(SpriteFont))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "DrawStringWithShadow", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(string),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(float),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 47)]
		public void Draw(String_Layout layout = null, float MaxHeight = 0f)
		{
			throw null;
		}

		// Token: 0x06004282 RID: 17026 RVA: 0x0002DE3C File Offset: 0x0002C03C
		[global::Cpp2ILInjected.Token(Token = "0x6004E7A")]
		[global::Cpp2ILInjected.Address(RVA = "0x8E2130", Offset = "0x8E2130", Length = "0x2A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GameTipsDisplay), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_PrimaryInputMode", ReturnType = typeof(XNAUnityRunner.ForcedInputMode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isEditor", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanguageManager), Member = "RandomFromCategories", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(ref int),
			typeof(UnifiedRandom)
		}, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameTipsDisplay.GameTip), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private void AddNewTip(double currentTime)
		{
			throw null;
		}

		// Token: 0x04006EC3 RID: 28355
		[global::Cpp2ILInjected.Token(Token = "0x4008795")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private LocalizedText[] _tipsDefault;

		// Token: 0x04006EC4 RID: 28356
		[global::Cpp2ILInjected.Token(Token = "0x4008796")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private LocalizedText[] _tipsGamepad;

		// Token: 0x04006EC5 RID: 28357
		[global::Cpp2ILInjected.Token(Token = "0x4008797")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private LocalizedText[] _tipsKeyboard;

		// Token: 0x04006EC6 RID: 28358
		[global::Cpp2ILInjected.Token(Token = "0x4008798")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly List<GameTipsDisplay.GameTip> _currentTips;

		// Token: 0x04006EC7 RID: 28359
		[global::Cpp2ILInjected.Token(Token = "0x4008799")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private LocalizedText _lastTip;

		// Token: 0x04006EC8 RID: 28360
		[global::Cpp2ILInjected.Token(Token = "0x400879A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int _lastTipIndex;

		// Token: 0x02000A9F RID: 2719
		[global::Cpp2ILInjected.Token(Token = "0x2000A5F")]
		private class GameTip
		{
			// Token: 0x17000901 RID: 2305
			// (get) Token: 0x06005224 RID: 21028 RVA: 0x000307D6 File Offset: 0x0002E9D6
			[global::Cpp2ILInjected.Token(Token = "0x170008A0")]
			public string Text
			{
				[global::Cpp2ILInjected.Token(Token = "0x6004E7B")]
				[global::Cpp2ILInjected.Address(RVA = "0x8E2E5C", Offset = "0x8E2E5C", Length = "0x54")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06005225 RID: 21029 RVA: 0x000307D9 File Offset: 0x0002E9D9
			[global::Cpp2ILInjected.Token(Token = "0x6004E7C")]
			[global::Cpp2ILInjected.Address(RVA = "0x8E2F58", Offset = "0x8E2F58", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool IsExpired(double currentTime)
			{
				throw null;
			}

			// Token: 0x06005226 RID: 21030 RVA: 0x000307DC File Offset: 0x0002E9DC
			[global::Cpp2ILInjected.Token(Token = "0x6004E7D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8E210C", Offset = "0x8E210C", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool IsExpiring(double currentTime)
			{
				throw null;
			}

			// Token: 0x06005227 RID: 21031 RVA: 0x000307DF File Offset: 0x0002E9DF
			[global::Cpp2ILInjected.Token(Token = "0x6004E7E")]
			[global::Cpp2ILInjected.Address(RVA = "0x8E2EB0", Offset = "0x8E2EB0", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GameTipsDisplay), Member = "AddNewTip", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "CreateDialogSubstitutionObject", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalizedText), Member = "FormatWith", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public GameTip(LocalizedText text, double spawnTime)
			{
				throw null;
			}

			// Token: 0x06005228 RID: 21032 RVA: 0x000307E2 File Offset: 0x0002E9E2
			[global::Cpp2ILInjected.Token(Token = "0x6004E7F")]
			[global::Cpp2ILInjected.Address(RVA = "0x8E23D4", Offset = "0x8E23D4", Length = "0x100")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GameTipsDisplay), Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetLerpValue", MemberParameters = new object[]
			{
				typeof(double),
				typeof(double),
				typeof(double),
				typeof(bool)
			}, ReturnType = typeof(double))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "SmoothStep", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public void Update(double currentTime)
			{
				throw null;
			}

			// Token: 0x04008EE5 RID: 36581
			[global::Cpp2ILInjected.Token(Token = "0x400879B")]
			private const float APPEAR_FROM = 2.5f;

			// Token: 0x04008EE6 RID: 36582
			[global::Cpp2ILInjected.Token(Token = "0x400879C")]
			private const float APPEAR_TO = 0.5f;

			// Token: 0x04008EE7 RID: 36583
			[global::Cpp2ILInjected.Token(Token = "0x400879D")]
			private const float DISAPPEAR_TO = -1.5f;

			// Token: 0x04008EE8 RID: 36584
			[global::Cpp2ILInjected.Token(Token = "0x400879E")]
			private const float APPEAR_TIME = 0.5f;

			// Token: 0x04008EE9 RID: 36585
			[global::Cpp2ILInjected.Token(Token = "0x400879F")]
			private const float DISAPPEAR_TIME = 1f;

			// Token: 0x04008EEA RID: 36586
			[global::Cpp2ILInjected.Token(Token = "0x40087A0")]
			private const float DURATION = 11.5f;

			// Token: 0x04008EEB RID: 36587
			[global::Cpp2ILInjected.Token(Token = "0x40087A1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private LocalizedText _textKey;

			// Token: 0x04008EEC RID: 36588
			[global::Cpp2ILInjected.Token(Token = "0x40087A2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private string _formattedText;

			// Token: 0x04008EED RID: 36589
			[global::Cpp2ILInjected.Token(Token = "0x40087A3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public float ScreenAnchorX;

			// Token: 0x04008EEE RID: 36590
			[global::Cpp2ILInjected.Token(Token = "0x40087A4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			public readonly float Duration;

			// Token: 0x04008EEF RID: 36591
			[global::Cpp2ILInjected.Token(Token = "0x40087A5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public readonly double SpawnTime;
		}

		// Token: 0x02000AA0 RID: 2720
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000A60")]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06005229 RID: 21033 RVA: 0x000307E5 File Offset: 0x0002E9E5
			[global::Cpp2ILInjected.Token(Token = "0x6004E80")]
			[global::Cpp2ILInjected.Address(RVA = "0x8E2104", Offset = "0x8E2104", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass8_0()
			{
				throw null;
			}

			// Token: 0x0600522A RID: 21034 RVA: 0x000307E8 File Offset: 0x0002E9E8
			[global::Cpp2ILInjected.Token(Token = "0x6004E81")]
			[global::Cpp2ILInjected.Address(RVA = "0x8E2F74", Offset = "0x8E2F74", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <Update>b__0(GameTipsDisplay.GameTip x)
			{
				throw null;
			}

			// Token: 0x04008EF0 RID: 36592
			[global::Cpp2ILInjected.Token(Token = "0x40087A6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public double time;
		}
	}
}
