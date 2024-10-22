﻿using System;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x20001AB")]
	internal class WindowsConsoleDriver : global::System.IConsoleDriver
	{
		[global::Cpp2ILInjected.Token(Token = "0x600100B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8C274", Offset = "0x1C8C274", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ConsoleDriver), Member = "CreateWindowsConsoleDriver", ReturnType = typeof(global::System.IConsoleDriver))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.WindowsConsoleDriver), Member = "GetStdHandle", MemberParameters = new object[] { typeof(global::System.Handles) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.WindowsConsoleDriver), Member = "GetConsoleScreenBufferInfo", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(ref global::System.ConsoleScreenBufferInfo)
		}, ReturnType = typeof(bool))]
		public WindowsConsoleDriver()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600100C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8C3E0", Offset = "0x1C8C3E0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.WindowsConsoleDriver), Member = "GetConsoleScreenBufferInfo", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(ref global::System.ConsoleScreenBufferInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.WindowsConsoleDriver), Member = "FillConsoleOutputCharacter", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(char),
			typeof(int),
			typeof(global::System.Coord),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.WindowsConsoleDriver), Member = "FillConsoleOutputAttribute", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(short),
			typeof(int),
			typeof(global::System.Coord),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.WindowsConsoleDriver), Member = "SetConsoleCursorPosition", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.Coord)
		}, ReturnType = typeof(bool))]
		public void Clear()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600100D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8C674", Offset = "0x1C8C674", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.WindowsConsoleDriver), Member = "ReadKey", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.ConsoleKeyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public string ReadLine()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600100E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8C700", Offset = "0x1C8C700", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.WindowsConsoleDriver), Member = "ReadLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.WindowsConsoleDriver), Member = "ReadConsoleInput", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(ref global::System.InputRecord),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ConsoleKeyInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(char),
			typeof(global::System.ConsoleKey),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public global::System.ConsoleKeyInfo ReadKey(bool intercept)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600100F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8C940", Offset = "0x1C8C940", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool IsModifierKey(short virtualKeyCode)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001010")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8C2C8", Offset = "0x1C8C2C8", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.WindowsConsoleDriver), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[global::System.Runtime.InteropServices.PreserveSig]
		private static extern global::System.IntPtr GetStdHandle(global::System.Handles handle);

		[global::Cpp2ILInjected.Token(Token = "0x6001011")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8C34C", Offset = "0x1C8C34C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.WindowsConsoleDriver), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.WindowsConsoleDriver), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[global::System.Runtime.InteropServices.PreserveSig]
		private static extern bool GetConsoleScreenBufferInfo(global::System.IntPtr handle, out global::System.ConsoleScreenBufferInfo info);

		[global::Cpp2ILInjected.Token(Token = "0x6001012")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8C46C", Offset = "0x1C8C46C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.WindowsConsoleDriver), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[global::System.Runtime.InteropServices.PreserveSig]
		private static extern bool FillConsoleOutputCharacter(global::System.IntPtr handle, char c, int size, global::System.Coord coord, out int written);

		[global::Cpp2ILInjected.Token(Token = "0x6001013")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8C528", Offset = "0x1C8C528", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.WindowsConsoleDriver), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[global::System.Runtime.InteropServices.PreserveSig]
		private static extern bool FillConsoleOutputAttribute(global::System.IntPtr handle, short c, int size, global::System.Coord coord, out int written);

		[global::Cpp2ILInjected.Token(Token = "0x6001014")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8C5E4", Offset = "0x1C8C5E4", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.WindowsConsoleDriver), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[global::System.Runtime.InteropServices.PreserveSig]
		private static extern bool SetConsoleCursorPosition(global::System.IntPtr handle, global::System.Coord coord);

		[global::Cpp2ILInjected.Token(Token = "0x6001015")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8C838", Offset = "0x1C8C838", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.WindowsConsoleDriver), Member = "ReadKey", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.ConsoleKeyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[global::System.Runtime.InteropServices.PreserveSig]
		private static extern bool ReadConsoleInput(global::System.IntPtr handle, out global::System.InputRecord record, int length, out int nread);

		[global::Cpp2ILInjected.Token(Token = "0x40008C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.IntPtr inputHandle;

		[global::Cpp2ILInjected.Token(Token = "0x40008C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.IntPtr outputHandle;

		[global::Cpp2ILInjected.Token(Token = "0x40008C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private short defaultAttribute;
	}
}
