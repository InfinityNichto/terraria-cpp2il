using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Localization;

namespace Terraria.UI
{
	[global::Cpp2ILInjected.Token(Token = "0x2000712")]
	public class ItemTooltip
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000761")]
		public int Lines
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003BF1")]
			[global::Cpp2ILInjected.Address(RVA = "0x148C074", Offset = "0x148C074", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "MouseText_DrawItemTooltip_GetLinesInfo", MemberParameters = new object[]
			{
				typeof(Item),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(float),
				typeof(ref int),
				typeof(string[]),
				typeof(bool[]),
				typeof(bool[]),
				typeof(ref int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemTooltip), Member = "ValidateTooltip", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003BF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x148C2A4", Offset = "0x148C2A4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private ItemTooltip()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003BF3")]
		[global::Cpp2ILInjected.Address(RVA = "0x148C2AC", Offset = "0x148C2AC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		private ItemTooltip(short id, string key)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003BF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x148C2E8", Offset = "0x148C2E8", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Lang.<>c", Member = "<InitializeLegacyLocalization>b__54_1", MemberParameters = new object[] { typeof(FieldInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static ItemTooltip FromLanguageKey(short id, string key)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003BF5")]
		[global::Cpp2ILInjected.Address(RVA = "0x148C394", Offset = "0x148C394", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "MouseText_DrawItemTooltip_GetLinesInfo", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(float),
			typeof(ref int),
			typeof(string[]),
			typeof(bool[]),
			typeof(bool[]),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemTooltip), Member = "ValidateTooltip", ReturnType = typeof(void))]
		public string GetLine(int line)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003BF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x148C09C", Offset = "0x148C09C", Length = "0x208")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemTooltip), Member = "get_Lines", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemTooltip), Member = "GetLine", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[]
		{
			typeof(char),
			typeof(StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private void ValidateTooltip()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003BF7")]
		[global::Cpp2ILInjected.Address(RVA = "0x148C3C0", Offset = "0x148C3C0", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "InitializeLegacyLocalization", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void AddGlobalProcessor(TooltipProcessor processor)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003BF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x148C484", Offset = "0x148C484", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void RemoveGlobalProcessor(TooltipProcessor processor)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003BF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x148C4FC", Offset = "0x148C4FC", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void ClearGlobalProcessors()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003BFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x148C58C", Offset = "0x148C58C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "RefreshLangStrings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main.<>c", Member = "<ClientInitialize>b__1854_0", MemberParameters = new object[] { typeof(LanguageManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void InvalidateTooltips()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003BFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x148C60C", Offset = "0x148C60C", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static ItemTooltip()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007B5B")]
		public static readonly ItemTooltip None;

		[global::Cpp2ILInjected.Token(Token = "0x4007B5C")]
		private static readonly List<TooltipProcessor> _globalProcessors;

		[global::Cpp2ILInjected.Token(Token = "0x4007B5D")]
		private static ulong _globalValidatorKey;

		[global::Cpp2ILInjected.Token(Token = "0x4007B5E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string[] _tooltipLines;

		[global::Cpp2ILInjected.Token(Token = "0x4007B5F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ulong _validatorKey;

		[global::Cpp2ILInjected.Token(Token = "0x4007B60")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly LocalizedText _text;

		[global::Cpp2ILInjected.Token(Token = "0x4007B61")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string _processedText;

		[global::Cpp2ILInjected.Token(Token = "0x4007B62")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly short _id;
	}
}
