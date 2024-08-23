using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria;
using UnityEngine;

// Token: 0x02000036 RID: 54
[global::Cpp2ILInjected.Token(Token = "0x2000056")]
internal static class KeyboardInput
{
	// Token: 0x0600014E RID: 334 RVA: 0x00021F62 File Offset: 0x00020162
	[global::Cpp2ILInjected.Token(Token = "0x60001D8")]
	[global::Cpp2ILInjected.Address(RVA = "0x708FB8", Offset = "0x708FB8", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void KeyboardUpdate()
	{
		throw null;
	}

	// Token: 0x0600014F RID: 335 RVA: 0x00021F65 File Offset: 0x00020165
	[global::Cpp2ILInjected.Token(Token = "0x60001D9")]
	[global::Cpp2ILInjected.Address(RVA = "0x708FBC", Offset = "0x708FBC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static bool KeyPressed(int keyCode)
	{
		throw null;
	}

	// Token: 0x06000150 RID: 336 RVA: 0x00021F68 File Offset: 0x00020168
	[global::Cpp2ILInjected.Token(Token = "0x60001DA")]
	[global::Cpp2ILInjected.Address(RVA = "0x708FC4", Offset = "0x708FC4", Length = "0x82C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaClass), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject[]), Member = "GetStatic", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject[]), Member = "Get", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject), Member = "GetRawObject", ReturnType = typeof(IntPtr))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNI), Member = "GetBooleanArrayElement", MemberParameters = new object[]
	{
		typeof(IntPtr),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetKey", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
	public static void Update()
	{
		throw null;
	}

	// Token: 0x06000151 RID: 337 RVA: 0x00021F6B File Offset: 0x0002016B
	[global::Cpp2ILInjected.Token(Token = "0x60001DB")]
	[global::Cpp2ILInjected.Address(RVA = "0x7097F0", Offset = "0x7097F0", Length = "0xAC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 30)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public static bool GetKey(KeyCode keycode)
	{
		throw null;
	}

	// Token: 0x06000152 RID: 338 RVA: 0x00021F6E File Offset: 0x0002016E
	[global::Cpp2ILInjected.Token(Token = "0x60001DC")]
	[global::Cpp2ILInjected.Address(RVA = "0x70989C", Offset = "0x70989C", Length = "0xD4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 48)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public static bool GetKeyUp(KeyCode keycode)
	{
		throw null;
	}

	// Token: 0x06000153 RID: 339 RVA: 0x00021F71 File Offset: 0x00020171
	[global::Cpp2ILInjected.Token(Token = "0x60001DD")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FE8C8", Offset = "0x6FE8C8", Length = "0xD4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DrKeyboard_IME), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAmmo), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuffs), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICoins), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "ItemOver", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		"GUIEquipment.EquipmentItemType",
		typeof(int),
		typeof(ref int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventory), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReturnToTouch), Member = "Draw", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMainMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuitConfirm), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MPSessionAPI_Dummy), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "GetInputText", MemberParameters = new object[]
	{
		typeof(string),
		typeof(Rectangle),
		typeof(int),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonDown", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public static bool GetKeyDown(KeyCode keycode)
	{
		throw null;
	}

	// Token: 0x06000154 RID: 340 RVA: 0x00021F74 File Offset: 0x00020174
	[global::Cpp2ILInjected.Token(Token = "0x60001DE")]
	[global::Cpp2ILInjected.Address(RVA = "0x709970", Offset = "0x709970", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public static void KeyboardInitialise()
	{
		throw null;
	}

	// Token: 0x06000155 RID: 341 RVA: 0x00021F77 File Offset: 0x00020177
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x60001DF")]
	[global::Cpp2ILInjected.Address(RVA = "0x709974", Offset = "0x709974", Length = "0x32C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	static KeyboardInput()
	{
		throw null;
	}

	// Token: 0x040000E6 RID: 230
	[global::Cpp2ILInjected.Token(Token = "0x400013F")]
	private static KeyboardInput.KeyCodeMapping[] keyMappings;

	// Token: 0x040000E7 RID: 231
	[global::Cpp2ILInjected.Token(Token = "0x4000140")]
	private static bool[] KeyStates;

	// Token: 0x040000E8 RID: 232
	[global::Cpp2ILInjected.Token(Token = "0x4000141")]
	private static bool[] KeyStatesOld;

	// Token: 0x040000E9 RID: 233
	[global::Cpp2ILInjected.Token(Token = "0x4000142")]
	private static AndroidJavaObject pressedStateArray;

	// Token: 0x040000EA RID: 234
	[global::Cpp2ILInjected.Token(Token = "0x4000143")]
	private static IntPtr pressedStateArracyValues;

	// Token: 0x02000782 RID: 1922
	[global::Cpp2ILInjected.Token(Token = "0x2000057")]
	public enum VirtualKey
	{
		// Token: 0x0400783F RID: 30783
		[global::Cpp2ILInjected.Token(Token = "0x4000145")]
		None,
		// Token: 0x04007840 RID: 30784
		[global::Cpp2ILInjected.Token(Token = "0x4000146")]
		LeftButton,
		// Token: 0x04007841 RID: 30785
		[global::Cpp2ILInjected.Token(Token = "0x4000147")]
		RightButton,
		// Token: 0x04007842 RID: 30786
		[global::Cpp2ILInjected.Token(Token = "0x4000148")]
		Cancel,
		// Token: 0x04007843 RID: 30787
		[global::Cpp2ILInjected.Token(Token = "0x4000149")]
		MiddleButton,
		// Token: 0x04007844 RID: 30788
		[global::Cpp2ILInjected.Token(Token = "0x400014A")]
		XButton1,
		// Token: 0x04007845 RID: 30789
		[global::Cpp2ILInjected.Token(Token = "0x400014B")]
		XButton2,
		// Token: 0x04007846 RID: 30790
		[global::Cpp2ILInjected.Token(Token = "0x400014C")]
		Back = 8,
		// Token: 0x04007847 RID: 30791
		[global::Cpp2ILInjected.Token(Token = "0x400014D")]
		Tab,
		// Token: 0x04007848 RID: 30792
		[global::Cpp2ILInjected.Token(Token = "0x400014E")]
		Clear = 12,
		// Token: 0x04007849 RID: 30793
		[global::Cpp2ILInjected.Token(Token = "0x400014F")]
		Enter,
		// Token: 0x0400784A RID: 30794
		[global::Cpp2ILInjected.Token(Token = "0x4000150")]
		Shift = 16,
		// Token: 0x0400784B RID: 30795
		[global::Cpp2ILInjected.Token(Token = "0x4000151")]
		Control,
		// Token: 0x0400784C RID: 30796
		[global::Cpp2ILInjected.Token(Token = "0x4000152")]
		Menu,
		// Token: 0x0400784D RID: 30797
		[global::Cpp2ILInjected.Token(Token = "0x4000153")]
		Pause,
		// Token: 0x0400784E RID: 30798
		[global::Cpp2ILInjected.Token(Token = "0x4000154")]
		CapitalLock,
		// Token: 0x0400784F RID: 30799
		[global::Cpp2ILInjected.Token(Token = "0x4000155")]
		Kana,
		// Token: 0x04007850 RID: 30800
		[global::Cpp2ILInjected.Token(Token = "0x4000156")]
		Hangul = 21,
		// Token: 0x04007851 RID: 30801
		[global::Cpp2ILInjected.Token(Token = "0x4000157")]
		Junja = 23,
		// Token: 0x04007852 RID: 30802
		[global::Cpp2ILInjected.Token(Token = "0x4000158")]
		Final,
		// Token: 0x04007853 RID: 30803
		[global::Cpp2ILInjected.Token(Token = "0x4000159")]
		Hanja,
		// Token: 0x04007854 RID: 30804
		[global::Cpp2ILInjected.Token(Token = "0x400015A")]
		Kanji = 25,
		// Token: 0x04007855 RID: 30805
		[global::Cpp2ILInjected.Token(Token = "0x400015B")]
		Escape = 27,
		// Token: 0x04007856 RID: 30806
		[global::Cpp2ILInjected.Token(Token = "0x400015C")]
		Convert,
		// Token: 0x04007857 RID: 30807
		[global::Cpp2ILInjected.Token(Token = "0x400015D")]
		NonConvert,
		// Token: 0x04007858 RID: 30808
		[global::Cpp2ILInjected.Token(Token = "0x400015E")]
		Accept,
		// Token: 0x04007859 RID: 30809
		[global::Cpp2ILInjected.Token(Token = "0x400015F")]
		ModeChange,
		// Token: 0x0400785A RID: 30810
		[global::Cpp2ILInjected.Token(Token = "0x4000160")]
		Space,
		// Token: 0x0400785B RID: 30811
		[global::Cpp2ILInjected.Token(Token = "0x4000161")]
		PageUp,
		// Token: 0x0400785C RID: 30812
		[global::Cpp2ILInjected.Token(Token = "0x4000162")]
		PageDown,
		// Token: 0x0400785D RID: 30813
		[global::Cpp2ILInjected.Token(Token = "0x4000163")]
		End,
		// Token: 0x0400785E RID: 30814
		[global::Cpp2ILInjected.Token(Token = "0x4000164")]
		Home,
		// Token: 0x0400785F RID: 30815
		[global::Cpp2ILInjected.Token(Token = "0x4000165")]
		Left,
		// Token: 0x04007860 RID: 30816
		[global::Cpp2ILInjected.Token(Token = "0x4000166")]
		Up,
		// Token: 0x04007861 RID: 30817
		[global::Cpp2ILInjected.Token(Token = "0x4000167")]
		Right,
		// Token: 0x04007862 RID: 30818
		[global::Cpp2ILInjected.Token(Token = "0x4000168")]
		Down,
		// Token: 0x04007863 RID: 30819
		[global::Cpp2ILInjected.Token(Token = "0x4000169")]
		Select,
		// Token: 0x04007864 RID: 30820
		[global::Cpp2ILInjected.Token(Token = "0x400016A")]
		Print,
		// Token: 0x04007865 RID: 30821
		[global::Cpp2ILInjected.Token(Token = "0x400016B")]
		Execute,
		// Token: 0x04007866 RID: 30822
		[global::Cpp2ILInjected.Token(Token = "0x400016C")]
		Snapshot,
		// Token: 0x04007867 RID: 30823
		[global::Cpp2ILInjected.Token(Token = "0x400016D")]
		Insert,
		// Token: 0x04007868 RID: 30824
		[global::Cpp2ILInjected.Token(Token = "0x400016E")]
		Delete,
		// Token: 0x04007869 RID: 30825
		[global::Cpp2ILInjected.Token(Token = "0x400016F")]
		Help,
		// Token: 0x0400786A RID: 30826
		[global::Cpp2ILInjected.Token(Token = "0x4000170")]
		Number0,
		// Token: 0x0400786B RID: 30827
		[global::Cpp2ILInjected.Token(Token = "0x4000171")]
		Number1,
		// Token: 0x0400786C RID: 30828
		[global::Cpp2ILInjected.Token(Token = "0x4000172")]
		Number2,
		// Token: 0x0400786D RID: 30829
		[global::Cpp2ILInjected.Token(Token = "0x4000173")]
		Number3,
		// Token: 0x0400786E RID: 30830
		[global::Cpp2ILInjected.Token(Token = "0x4000174")]
		Number4,
		// Token: 0x0400786F RID: 30831
		[global::Cpp2ILInjected.Token(Token = "0x4000175")]
		Number5,
		// Token: 0x04007870 RID: 30832
		[global::Cpp2ILInjected.Token(Token = "0x4000176")]
		Number6,
		// Token: 0x04007871 RID: 30833
		[global::Cpp2ILInjected.Token(Token = "0x4000177")]
		Number7,
		// Token: 0x04007872 RID: 30834
		[global::Cpp2ILInjected.Token(Token = "0x4000178")]
		Number8,
		// Token: 0x04007873 RID: 30835
		[global::Cpp2ILInjected.Token(Token = "0x4000179")]
		Number9,
		// Token: 0x04007874 RID: 30836
		[global::Cpp2ILInjected.Token(Token = "0x400017A")]
		A = 65,
		// Token: 0x04007875 RID: 30837
		[global::Cpp2ILInjected.Token(Token = "0x400017B")]
		B,
		// Token: 0x04007876 RID: 30838
		[global::Cpp2ILInjected.Token(Token = "0x400017C")]
		C,
		// Token: 0x04007877 RID: 30839
		[global::Cpp2ILInjected.Token(Token = "0x400017D")]
		D,
		// Token: 0x04007878 RID: 30840
		[global::Cpp2ILInjected.Token(Token = "0x400017E")]
		E,
		// Token: 0x04007879 RID: 30841
		[global::Cpp2ILInjected.Token(Token = "0x400017F")]
		F,
		// Token: 0x0400787A RID: 30842
		[global::Cpp2ILInjected.Token(Token = "0x4000180")]
		G,
		// Token: 0x0400787B RID: 30843
		[global::Cpp2ILInjected.Token(Token = "0x4000181")]
		H,
		// Token: 0x0400787C RID: 30844
		[global::Cpp2ILInjected.Token(Token = "0x4000182")]
		I,
		// Token: 0x0400787D RID: 30845
		[global::Cpp2ILInjected.Token(Token = "0x4000183")]
		J,
		// Token: 0x0400787E RID: 30846
		[global::Cpp2ILInjected.Token(Token = "0x4000184")]
		K,
		// Token: 0x0400787F RID: 30847
		[global::Cpp2ILInjected.Token(Token = "0x4000185")]
		L,
		// Token: 0x04007880 RID: 30848
		[global::Cpp2ILInjected.Token(Token = "0x4000186")]
		M,
		// Token: 0x04007881 RID: 30849
		[global::Cpp2ILInjected.Token(Token = "0x4000187")]
		N,
		// Token: 0x04007882 RID: 30850
		[global::Cpp2ILInjected.Token(Token = "0x4000188")]
		O,
		// Token: 0x04007883 RID: 30851
		[global::Cpp2ILInjected.Token(Token = "0x4000189")]
		P,
		// Token: 0x04007884 RID: 30852
		[global::Cpp2ILInjected.Token(Token = "0x400018A")]
		Q,
		// Token: 0x04007885 RID: 30853
		[global::Cpp2ILInjected.Token(Token = "0x400018B")]
		R,
		// Token: 0x04007886 RID: 30854
		[global::Cpp2ILInjected.Token(Token = "0x400018C")]
		S,
		// Token: 0x04007887 RID: 30855
		[global::Cpp2ILInjected.Token(Token = "0x400018D")]
		T,
		// Token: 0x04007888 RID: 30856
		[global::Cpp2ILInjected.Token(Token = "0x400018E")]
		U,
		// Token: 0x04007889 RID: 30857
		[global::Cpp2ILInjected.Token(Token = "0x400018F")]
		V,
		// Token: 0x0400788A RID: 30858
		[global::Cpp2ILInjected.Token(Token = "0x4000190")]
		W,
		// Token: 0x0400788B RID: 30859
		[global::Cpp2ILInjected.Token(Token = "0x4000191")]
		X,
		// Token: 0x0400788C RID: 30860
		[global::Cpp2ILInjected.Token(Token = "0x4000192")]
		Y,
		// Token: 0x0400788D RID: 30861
		[global::Cpp2ILInjected.Token(Token = "0x4000193")]
		Z,
		// Token: 0x0400788E RID: 30862
		[global::Cpp2ILInjected.Token(Token = "0x4000194")]
		LeftWindows,
		// Token: 0x0400788F RID: 30863
		[global::Cpp2ILInjected.Token(Token = "0x4000195")]
		RightWindows,
		// Token: 0x04007890 RID: 30864
		[global::Cpp2ILInjected.Token(Token = "0x4000196")]
		Application,
		// Token: 0x04007891 RID: 30865
		[global::Cpp2ILInjected.Token(Token = "0x4000197")]
		Sleep = 95,
		// Token: 0x04007892 RID: 30866
		[global::Cpp2ILInjected.Token(Token = "0x4000198")]
		NumberPad0,
		// Token: 0x04007893 RID: 30867
		[global::Cpp2ILInjected.Token(Token = "0x4000199")]
		NumberPad1,
		// Token: 0x04007894 RID: 30868
		[global::Cpp2ILInjected.Token(Token = "0x400019A")]
		NumberPad2,
		// Token: 0x04007895 RID: 30869
		[global::Cpp2ILInjected.Token(Token = "0x400019B")]
		NumberPad3,
		// Token: 0x04007896 RID: 30870
		[global::Cpp2ILInjected.Token(Token = "0x400019C")]
		NumberPad4,
		// Token: 0x04007897 RID: 30871
		[global::Cpp2ILInjected.Token(Token = "0x400019D")]
		NumberPad5,
		// Token: 0x04007898 RID: 30872
		[global::Cpp2ILInjected.Token(Token = "0x400019E")]
		NumberPad6,
		// Token: 0x04007899 RID: 30873
		[global::Cpp2ILInjected.Token(Token = "0x400019F")]
		NumberPad7,
		// Token: 0x0400789A RID: 30874
		[global::Cpp2ILInjected.Token(Token = "0x40001A0")]
		NumberPad8,
		// Token: 0x0400789B RID: 30875
		[global::Cpp2ILInjected.Token(Token = "0x40001A1")]
		NumberPad9,
		// Token: 0x0400789C RID: 30876
		[global::Cpp2ILInjected.Token(Token = "0x40001A2")]
		Multiply,
		// Token: 0x0400789D RID: 30877
		[global::Cpp2ILInjected.Token(Token = "0x40001A3")]
		Add,
		// Token: 0x0400789E RID: 30878
		[global::Cpp2ILInjected.Token(Token = "0x40001A4")]
		Separator,
		// Token: 0x0400789F RID: 30879
		[global::Cpp2ILInjected.Token(Token = "0x40001A5")]
		Subtract,
		// Token: 0x040078A0 RID: 30880
		[global::Cpp2ILInjected.Token(Token = "0x40001A6")]
		Decimal,
		// Token: 0x040078A1 RID: 30881
		[global::Cpp2ILInjected.Token(Token = "0x40001A7")]
		Divide,
		// Token: 0x040078A2 RID: 30882
		[global::Cpp2ILInjected.Token(Token = "0x40001A8")]
		F1,
		// Token: 0x040078A3 RID: 30883
		[global::Cpp2ILInjected.Token(Token = "0x40001A9")]
		F2,
		// Token: 0x040078A4 RID: 30884
		[global::Cpp2ILInjected.Token(Token = "0x40001AA")]
		F3,
		// Token: 0x040078A5 RID: 30885
		[global::Cpp2ILInjected.Token(Token = "0x40001AB")]
		F4,
		// Token: 0x040078A6 RID: 30886
		[global::Cpp2ILInjected.Token(Token = "0x40001AC")]
		F5,
		// Token: 0x040078A7 RID: 30887
		[global::Cpp2ILInjected.Token(Token = "0x40001AD")]
		F6,
		// Token: 0x040078A8 RID: 30888
		[global::Cpp2ILInjected.Token(Token = "0x40001AE")]
		F7,
		// Token: 0x040078A9 RID: 30889
		[global::Cpp2ILInjected.Token(Token = "0x40001AF")]
		F8,
		// Token: 0x040078AA RID: 30890
		[global::Cpp2ILInjected.Token(Token = "0x40001B0")]
		F9,
		// Token: 0x040078AB RID: 30891
		[global::Cpp2ILInjected.Token(Token = "0x40001B1")]
		F10,
		// Token: 0x040078AC RID: 30892
		[global::Cpp2ILInjected.Token(Token = "0x40001B2")]
		F11,
		// Token: 0x040078AD RID: 30893
		[global::Cpp2ILInjected.Token(Token = "0x40001B3")]
		F12,
		// Token: 0x040078AE RID: 30894
		[global::Cpp2ILInjected.Token(Token = "0x40001B4")]
		F13,
		// Token: 0x040078AF RID: 30895
		[global::Cpp2ILInjected.Token(Token = "0x40001B5")]
		F14,
		// Token: 0x040078B0 RID: 30896
		[global::Cpp2ILInjected.Token(Token = "0x40001B6")]
		F15,
		// Token: 0x040078B1 RID: 30897
		[global::Cpp2ILInjected.Token(Token = "0x40001B7")]
		F16,
		// Token: 0x040078B2 RID: 30898
		[global::Cpp2ILInjected.Token(Token = "0x40001B8")]
		F17,
		// Token: 0x040078B3 RID: 30899
		[global::Cpp2ILInjected.Token(Token = "0x40001B9")]
		F18,
		// Token: 0x040078B4 RID: 30900
		[global::Cpp2ILInjected.Token(Token = "0x40001BA")]
		F19,
		// Token: 0x040078B5 RID: 30901
		[global::Cpp2ILInjected.Token(Token = "0x40001BB")]
		F20,
		// Token: 0x040078B6 RID: 30902
		[global::Cpp2ILInjected.Token(Token = "0x40001BC")]
		F21,
		// Token: 0x040078B7 RID: 30903
		[global::Cpp2ILInjected.Token(Token = "0x40001BD")]
		F22,
		// Token: 0x040078B8 RID: 30904
		[global::Cpp2ILInjected.Token(Token = "0x40001BE")]
		F23,
		// Token: 0x040078B9 RID: 30905
		[global::Cpp2ILInjected.Token(Token = "0x40001BF")]
		F24,
		// Token: 0x040078BA RID: 30906
		[global::Cpp2ILInjected.Token(Token = "0x40001C0")]
		NumberKeyLock = 144,
		// Token: 0x040078BB RID: 30907
		[global::Cpp2ILInjected.Token(Token = "0x40001C1")]
		Scroll,
		// Token: 0x040078BC RID: 30908
		[global::Cpp2ILInjected.Token(Token = "0x40001C2")]
		LeftShift = 160,
		// Token: 0x040078BD RID: 30909
		[global::Cpp2ILInjected.Token(Token = "0x40001C3")]
		RightShift,
		// Token: 0x040078BE RID: 30910
		[global::Cpp2ILInjected.Token(Token = "0x40001C4")]
		LeftControl,
		// Token: 0x040078BF RID: 30911
		[global::Cpp2ILInjected.Token(Token = "0x40001C5")]
		RightControl,
		// Token: 0x040078C0 RID: 30912
		[global::Cpp2ILInjected.Token(Token = "0x40001C6")]
		LeftMenu,
		// Token: 0x040078C1 RID: 30913
		[global::Cpp2ILInjected.Token(Token = "0x40001C7")]
		RightMenu,
		// Token: 0x040078C2 RID: 30914
		[global::Cpp2ILInjected.Token(Token = "0x40001C8")]
		Semicolon = 186,
		// Token: 0x040078C3 RID: 30915
		[global::Cpp2ILInjected.Token(Token = "0x40001C9")]
		Equals,
		// Token: 0x040078C4 RID: 30916
		[global::Cpp2ILInjected.Token(Token = "0x40001CA")]
		Comma,
		// Token: 0x040078C5 RID: 30917
		[global::Cpp2ILInjected.Token(Token = "0x40001CB")]
		Minus,
		// Token: 0x040078C6 RID: 30918
		[global::Cpp2ILInjected.Token(Token = "0x40001CC")]
		Period,
		// Token: 0x040078C7 RID: 30919
		[global::Cpp2ILInjected.Token(Token = "0x40001CD")]
		Slash,
		// Token: 0x040078C8 RID: 30920
		[global::Cpp2ILInjected.Token(Token = "0x40001CE")]
		BackQuote,
		// Token: 0x040078C9 RID: 30921
		[global::Cpp2ILInjected.Token(Token = "0x40001CF")]
		LeftBracket = 219,
		// Token: 0x040078CA RID: 30922
		[global::Cpp2ILInjected.Token(Token = "0x40001D0")]
		RightBracket = 221,
		// Token: 0x040078CB RID: 30923
		[global::Cpp2ILInjected.Token(Token = "0x40001D1")]
		Quote,
		// Token: 0x040078CC RID: 30924
		[global::Cpp2ILInjected.Token(Token = "0x40001D2")]
		Backslash = 226
	}

	// Token: 0x02000783 RID: 1923
	[global::Cpp2ILInjected.Token(Token = "0x2000058")]
	public struct KeyCodeMapping
	{
		// Token: 0x0600485D RID: 18525 RVA: 0x0002EE74 File Offset: 0x0002D074
		[global::Cpp2ILInjected.Token(Token = "0x60001E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x709CA0", Offset = "0x709CA0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public KeyCodeMapping(KeyboardInput.VirtualKey vKey, KeyCode code)
		{
			throw null;
		}

		// Token: 0x040078CD RID: 30925
		[global::Cpp2ILInjected.Token(Token = "0x40001D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public KeyCode keyCode;

		// Token: 0x040078CE RID: 30926
		[global::Cpp2ILInjected.Token(Token = "0x40001D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public KeyboardInput.VirtualKey virtualKey;
	}
}
