using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x200016B")]
	public static class Console
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000E94")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C79D9C", Offset = "0x1C79D9C", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console.WindowsConsole), Member = "GetInputCodePage", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console.WindowsConsole), Member = "GetOutputCodePage", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.EncodingHelper), Member = "InternalCodePage", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_Default", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.EncodingHelper), Member = "get_UTF8Unmarked", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console), Member = "SetupStreams", MemberParameters = new object[]
		{
			typeof(global::System.Text.Encoding),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		static Console()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E95")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7A030", Offset = "0x1C7A030", Length = "0x394")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = "set_InputEncoding", MemberParameters = new object[] { typeof(global::System.Text.Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = "set_OutputEncoding", MemberParameters = new object[] { typeof(global::System.Text.Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ConsoleDriver), Member = "get_IsConsole", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console), Member = "OpenStandardInput", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.CStreamReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console), Member = "OpenStandardOutput", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.CStreamWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(global::System.Text.Encoding),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.TextWriter), Member = "Synchronized", MemberParameters = new object[] { typeof(global::System.IO.TextWriter) }, ReturnType = typeof(global::System.IO.TextWriter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console), Member = "OpenStandardError", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.UnexceptionalStreamReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.TextReader), Member = "Synchronized", MemberParameters = new object[] { typeof(global::System.IO.TextReader) }, ReturnType = typeof(global::System.IO.TextReader))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.UnexceptionalStreamWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		private static void SetupStreams(global::System.Text.Encoding inputEncoding, global::System.Text.Encoding outputEncoding)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000151")]
		public static global::System.IO.TextWriter Error
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E96")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C7A6AC", Offset = "0x1C7A6AC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000152")]
		public static global::System.IO.TextWriter Out
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E97")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C7A704", Offset = "0x1C7A704", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E98")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7A75C", Offset = "0x1C7A75C", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = "OpenStandardError", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = "OpenStandardInput", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = "OpenStandardOutput", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.FileStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IO.FileAccess),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private static global::System.IO.Stream Open(global::System.IntPtr handle, global::System.IO.FileAccess access, int bufferSize)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E99")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7A61C", Offset = "0x1C7A61C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = "SetupStreams", MemberParameters = new object[]
		{
			typeof(global::System.Text.Encoding),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.MonoIO), Member = "get_ConsoleError", ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console), Member = "Open", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IO.FileAccess),
			typeof(int)
		}, ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static global::System.IO.Stream OpenStandardError(int bufferSize)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E9A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7A4FC", Offset = "0x1C7A4FC", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = "SetupStreams", MemberParameters = new object[]
		{
			typeof(global::System.Text.Encoding),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.MonoIO), Member = "get_ConsoleInput", ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console), Member = "Open", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IO.FileAccess),
			typeof(int)
		}, ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static global::System.IO.Stream OpenStandardInput(int bufferSize)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E9B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7A58C", Offset = "0x1C7A58C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = "SetupStreams", MemberParameters = new object[]
		{
			typeof(global::System.Text.Encoding),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.MonoIO), Member = "get_ConsoleOutput", ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console), Member = "Open", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IO.FileAccess),
			typeof(int)
		}, ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static global::System.IO.Stream OpenStandardOutput(int bufferSize)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E9C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7A8AC", Offset = "0x1C7A8AC", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.IO.ConsoleOutputMirror", Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.IO.ConsoleOutputMirror", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UnityLogWriter", Member = "Init", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.TextWriter), Member = "Synchronized", MemberParameters = new object[] { typeof(global::System.IO.TextWriter) }, ReturnType = typeof(global::System.IO.TextWriter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static void SetOut(global::System.IO.TextWriter newOut)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E9D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7A98C", Offset = "0x1C7A98C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "startDedInputCallBack", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utilities.CrashWatcher.<>c", Member = "<Inititialize>b__18_0", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utilities.CrashWatcher.<>c", Member = "<Inititialize>b__18_1", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.UnhandledExceptionEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void Write(string value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E9E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7A9F8", Offset = "0x1C7A9F8", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "TraceWriteLine", MemberParameters = new object[]
		{
			typeof(string),
			"System.Object[]"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.BZip2.BZip2OutputStream", Member = "TraceOutput", MemberParameters = new object[]
		{
			"Ionic.BZip2.BZip2OutputStream.TraceBits",
			typeof(string),
			"System.Object[]"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void Write(string format, object arg0)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7AA74", Offset = "0x1C7AA74", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WorldFile_OldConsole", Member = "LoadFileFormatHeader", MemberParameters = new object[]
		{
			typeof(global::System.IO.BinaryReader),
			"System.Boolean[]&",
			"System.Int32[]&"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WorldFile_OldSwitch", Member = "LoadFileFormatHeader", MemberParameters = new object[]
		{
			typeof(global::System.IO.BinaryReader),
			"System.Boolean[]&",
			"System.Int32[]&"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.WorldFile", Member = "LoadFileFormatHeader", MemberParameters = new object[]
		{
			typeof(global::System.IO.BinaryReader),
			"System.Boolean[]&",
			"System.Int32[]&",
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void WriteLine(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7AAE0", Offset = "0x1C7AAE0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WorldFile_OldConsole", Member = "LoadFileFormatHeader", MemberParameters = new object[]
		{
			typeof(global::System.IO.BinaryReader),
			"System.Boolean[]&",
			"System.Int32[]&"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WorldFile_OldSwitch", Member = "LoadFileFormatHeader", MemberParameters = new object[]
		{
			typeof(global::System.IO.BinaryReader),
			"System.Boolean[]&",
			"System.Int32[]&"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Liquid", Member = "StartPanic", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Liquid", Member = "UpdateLiquid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "startDedInputCallBack", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DoUpdate", MemberParameters = new object[] { "Microsoft.Xna.Framework.GameTime" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "PrintTimedMessage", MemberParameters = new object[]
		{
			typeof(string),
			"System.Object[]"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.NetMessage", Member = "SyncOnePlayer", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Program", Member = "SetupLogging", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen", Member = "playWorldCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen", Member = "serverLoadWorldCallBack", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utilities.CrashWatcher", Member = "Inititialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utilities.MultiTimer", Member = "StopAndPrint", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Localization.LanguageManager", Member = "LoadFilesForCulture", MemberParameters = new object[] { "Terraria.Localization.GameCulture" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.Preferences", Member = "Save", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.WorldFile", Member = "LoadFileFormatHeader", MemberParameters = new object[]
		{
			typeof(global::System.IO.BinaryReader),
			"System.Boolean[]&",
			"System.Int32[]&",
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.DataStructures.BufferPool", Member = "PrintBufferSizes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.LegacyNetBufferPool", Member = "PrintBufferSizes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.Sockets.TcpSocket", Member = "ListenLoop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Utilities.MultiTimer", Member = "StopAndPrint", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "DeleteFileWithRetry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 62)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void WriteLine(string value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EA1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7AB4C", Offset = "0x1C7AB4C", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "TraceWriteLine", MemberParameters = new object[]
		{
			typeof(string),
			"System.Object[]"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.BZip2.BZip2OutputStream", Member = "TraceOutput", MemberParameters = new object[]
		{
			"Ionic.BZip2.BZip2OutputStream.TraceBits",
			typeof(string),
			"System.Object[]"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void WriteLine(string format, params object[] arg)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EA2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7ABE8", Offset = "0x1C7ABE8", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.FavoritesFile", Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Chat.Commands.SayChatCommand", Member = "ProcessIncomingMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Liquid.LiquidRenderer", Member = "SetWaveMaskData", MemberParameters = new object[] { "Microsoft.Xna.Framework.Graphics.Texture2D&" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.IO.ConsoleOutputMirror", Member = "ToFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void WriteLine(string format, object arg0, object arg1)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EA3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7AC6C", Offset = "0x1C7AC6C", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "ReadLineInput", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ConsoleDriver), Member = "get_IsConsole", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static string ReadLine()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000153")]
		public static global::System.Text.Encoding InputEncoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000EA4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C7AE3C", Offset = "0x1C7AE3C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000EA5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C7AE94", Offset = "0x1C7AE94", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Program", Member = "InitializeConsoleOutput", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console), Member = "SetupStreams", MemberParameters = new object[]
			{
				typeof(global::System.Text.Encoding),
				typeof(global::System.Text.Encoding)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000154")]
		public static global::System.Text.Encoding OutputEncoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000EA6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C7AEF8", Offset = "0x1C7AEF8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000EA7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C7AF50", Offset = "0x1C7AF50", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Program", Member = "InitializeConsoleOutput", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console), Member = "SetupStreams", MemberParameters = new object[]
			{
				typeof(global::System.Text.Encoding),
				typeof(global::System.Text.Encoding)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EA8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7AFB4", Offset = "0x1C7AFB4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DedServ", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "startDedInputCallBack", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Clear()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EA9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7B0C0", Offset = "0x1C7B0C0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.CStreamReader), Member = "Read", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console), Member = "ReadKey", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.ConsoleKeyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static global::System.ConsoleKeyInfo ReadKey()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EAA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7B118", Offset = "0x1C7B118", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = "ReadKey", ReturnType = typeof(global::System.ConsoleKeyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ConsoleDriver), Member = "ReadKey", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.ConsoleKeyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static global::System.ConsoleKeyInfo ReadKey(bool intercept)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EAB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7B248", Offset = "0x1C7B248", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console.WindowsConsole), Member = "DoWindowsConsoleCancelEvent", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ConsoleCancelEventArgs), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.ConsoleSpecialKey) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private static void DoConsoleCancelEvent()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400064E")]
		internal static global::System.IO.TextWriter stdout;

		[global::Cpp2ILInjected.Token(Token = "0x400064F")]
		private static global::System.IO.TextWriter stderr;

		[global::Cpp2ILInjected.Token(Token = "0x4000650")]
		private static global::System.IO.TextReader stdin;

		[global::Cpp2ILInjected.Token(Token = "0x4000651")]
		private static global::System.Text.Encoding inputEncoding;

		[global::Cpp2ILInjected.Token(Token = "0x4000652")]
		private static global::System.Text.Encoding outputEncoding;

		[global::Cpp2ILInjected.Token(Token = "0x4000653")]
		private static global::System.ConsoleCancelEventHandler cancel_event;

		[global::Cpp2ILInjected.Token(Token = "0x200016C")]
		private class WindowsConsole
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000EAC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C7B418", Offset = "0x1C7B418", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console.WindowsConsole), Member = "GetInputCodePage", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[global::System.Runtime.InteropServices.PreserveSig]
			private static extern int GetConsoleCP();

			[global::Cpp2ILInjected.Token(Token = "0x6000EAD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C7B480", Offset = "0x1C7B480", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console.WindowsConsole), Member = "GetOutputCodePage", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[global::System.Runtime.InteropServices.PreserveSig]
			private static extern int GetConsoleOutputCP();

			[global::Cpp2ILInjected.Token(Token = "0x6000EAE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C7B4EC", Offset = "0x1C7B4EC", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console), Member = "DoConsoleCancelEvent", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private static bool DoWindowsConsoleCancelEvent(int keyCode)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000EAF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C79F98", Offset = "0x1C79F98", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console.WindowsConsole), Member = "GetConsoleCP", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(8)]
			public static int GetInputCodePage()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000EB0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C79FE4", Offset = "0x1C79FE4", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console.WindowsConsole), Member = "GetConsoleOutputCP", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(8)]
			public static int GetOutputCodePage()
			{
				throw null;
			}

			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6000EB1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C7B54C", Offset = "0x1C7B54C", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Console.WindowsConsole.WindowsCancelHandler", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			static WindowsConsole()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000654")]
			public static bool ctrlHandlerAdded;

			[global::Cpp2ILInjected.Token(Token = "0x4000655")]
			private static global::System.Console.WindowsConsole.WindowsCancelHandler cancelHandler;

			[global::Cpp2ILInjected.Token(Token = "0x200016D")]
			private delegate bool WindowsCancelHandler(int keyCode);
		}
	}
}
