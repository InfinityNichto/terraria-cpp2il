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
	[global::Cpp2ILInjected.Token(Token = "0x2000A5E")]
	public class GameTipsDisplay
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x4008795")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private LocalizedText[] _tipsDefault;

		[global::Cpp2ILInjected.Token(Token = "0x4008796")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private LocalizedText[] _tipsGamepad;

		[global::Cpp2ILInjected.Token(Token = "0x4008797")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private LocalizedText[] _tipsKeyboard;

		[global::Cpp2ILInjected.Token(Token = "0x4008798")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly List<GameTipsDisplay.GameTip> _currentTips;

		[global::Cpp2ILInjected.Token(Token = "0x4008799")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private LocalizedText _lastTip;

		[global::Cpp2ILInjected.Token(Token = "0x400879A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int _lastTipIndex;

		[global::Cpp2ILInjected.Token(Token = "0x2000A5F")]
		private class GameTip
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x6004E7C")]
			[global::Cpp2ILInjected.Address(RVA = "0x8E2F58", Offset = "0x8E2F58", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool IsExpired(double currentTime)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004E7D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8E210C", Offset = "0x8E210C", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool IsExpiring(double currentTime)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x400879B")]
			private const float APPEAR_FROM = 2.5f;

			[global::Cpp2ILInjected.Token(Token = "0x400879C")]
			private const float APPEAR_TO = 0.5f;

			[global::Cpp2ILInjected.Token(Token = "0x400879D")]
			private const float DISAPPEAR_TO = -1.5f;

			[global::Cpp2ILInjected.Token(Token = "0x400879E")]
			private const float APPEAR_TIME = 0.5f;

			[global::Cpp2ILInjected.Token(Token = "0x400879F")]
			private const float DISAPPEAR_TIME = 1f;

			[global::Cpp2ILInjected.Token(Token = "0x40087A0")]
			private const float DURATION = 11.5f;

			[global::Cpp2ILInjected.Token(Token = "0x40087A1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private LocalizedText _textKey;

			[global::Cpp2ILInjected.Token(Token = "0x40087A2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private string _formattedText;

			[global::Cpp2ILInjected.Token(Token = "0x40087A3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public float ScreenAnchorX;

			[global::Cpp2ILInjected.Token(Token = "0x40087A4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			public readonly float Duration;

			[global::Cpp2ILInjected.Token(Token = "0x40087A5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public readonly double SpawnTime;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000A60")]
		private sealed class <>c__DisplayClass8_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004E80")]
			[global::Cpp2ILInjected.Address(RVA = "0x8E2104", Offset = "0x8E2104", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass8_0()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004E81")]
			[global::Cpp2ILInjected.Address(RVA = "0x8E2F74", Offset = "0x8E2F74", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <Update>b__0(GameTipsDisplay.GameTip x)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40087A6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public double time;
		}
	}
}
