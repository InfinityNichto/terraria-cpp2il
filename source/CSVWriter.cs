using System;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000035 RID: 53
[global::Cpp2ILInjected.Token(Token = "0x2000055")]
public class CSVWriter
{
	// Token: 0x06000144 RID: 324 RVA: 0x00021F44 File Offset: 0x00020144
	[global::Cpp2ILInjected.Token(Token = "0x60001CE")]
	[global::Cpp2ILInjected.Address(RVA = "0x708AA4", Offset = "0x708AA4", Length = "0x68")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControllerInputState), Member = "SaveDefaultCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "SetAttributes", MemberParameters = new object[]
	{
		typeof(string),
		typeof(FileAttributes)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Delete", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CSVWriter), Member = "SetupStreams", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CSVWriter), Member = "WriteLine", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(void))]
	public CSVWriter(string file, string[] headers)
	{
		throw null;
	}

	// Token: 0x06000145 RID: 325 RVA: 0x00021F47 File Offset: 0x00020147
	[global::Cpp2ILInjected.Token(Token = "0x60001CF")]
	[global::Cpp2ILInjected.Address(RVA = "0x708C8C", Offset = "0x708C8C", Length = "0x78")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "SetAttributes", MemberParameters = new object[]
	{
		typeof(string),
		typeof(FileAttributes)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Delete", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CSVWriter), Member = "SetupStreams", MemberParameters = new object[] { typeof(UTF8Encoding) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CSVWriter), Member = "WriteLine", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(void))]
	public CSVWriter(string file, string[] headers, UTF8Encoding enc)
	{
		throw null;
	}

	// Token: 0x06000146 RID: 326 RVA: 0x00021F4A File Offset: 0x0002014A
	[global::Cpp2ILInjected.Token(Token = "0x60001D0")]
	[global::Cpp2ILInjected.Address(RVA = "0x708DA4", Offset = "0x708DA4", Length = "0x34")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CSVWriter), Member = "SetupStreams", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CSVWriter), Member = "WriteLine", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(void))]
	public CSVWriter(string[] headers)
	{
		throw null;
	}

	// Token: 0x06000147 RID: 327 RVA: 0x00021F4D File Offset: 0x0002014D
	[global::Cpp2ILInjected.Token(Token = "0x60001D1")]
	[global::Cpp2ILInjected.Address(RVA = "0x708B0C", Offset = "0x708B0C", Length = "0x98")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CSVWriter), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CSVWriter), Member = ".ctor", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	private void SetupStreams()
	{
		throw null;
	}

	// Token: 0x06000148 RID: 328 RVA: 0x00021F50 File Offset: 0x00020150
	[global::Cpp2ILInjected.Token(Token = "0x60001D2")]
	[global::Cpp2ILInjected.Address(RVA = "0x708D04", Offset = "0x708D04", Length = "0xA0")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CSVWriter), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string[]),
		typeof(UTF8Encoding)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(Stream),
		typeof(Encoding)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	private void SetupStreams(UTF8Encoding enc)
	{
		throw null;
	}

	// Token: 0x06000149 RID: 329 RVA: 0x00021F53 File Offset: 0x00020153
	[global::Cpp2ILInjected.Token(Token = "0x60001D3")]
	[global::Cpp2ILInjected.Address(RVA = "0x708DD8", Offset = "0x708DD8", Length = "0x70")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CSVWriter), Member = "Finalize", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CSVWriter), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "WriteAllBytes", MemberParameters = new object[]
	{
		typeof(string),
		typeof(byte[])
	}, ReturnType = typeof(void))]
	private void CloseStreams()
	{
		throw null;
	}

	// Token: 0x0600014A RID: 330 RVA: 0x00021F56 File Offset: 0x00020156
	[global::Cpp2ILInjected.Token(Token = "0x60001D4")]
	[global::Cpp2ILInjected.Address(RVA = "0x708E48", Offset = "0x708E48", Length = "0x94")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CSVWriter), Member = "CloseStreams", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	protected override void Finalize()
	{
		throw null;
	}

	// Token: 0x0600014B RID: 331 RVA: 0x00021F59 File Offset: 0x00020159
	[global::Cpp2ILInjected.Token(Token = "0x60001D5")]
	[global::Cpp2ILInjected.Address(RVA = "0x708EDC", Offset = "0x708EDC", Length = "0xD8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CSVWriter), Member = "WriteLine", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private string EncodeValue(string stringValue)
	{
		throw null;
	}

	// Token: 0x0600014C RID: 332 RVA: 0x00021F5C File Offset: 0x0002015C
	[global::Cpp2ILInjected.Token(Token = "0x60001D6")]
	[global::Cpp2ILInjected.Address(RVA = "0x708BA4", Offset = "0x708BA4", Length = "0xE8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CSVWriter), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CSVWriter), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string[]),
		typeof(UTF8Encoding)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CSVWriter), Member = ".ctor", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControllerInputState), Member = "SaveDefaultCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CSVWriter), Member = "EncodeValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public void WriteLine(string[] values)
	{
		throw null;
	}

	// Token: 0x0600014D RID: 333 RVA: 0x00021F5F File Offset: 0x0002015F
	[global::Cpp2ILInjected.Token(Token = "0x60001D7")]
	[global::Cpp2ILInjected.Address(RVA = "0x708FB4", Offset = "0x708FB4", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControllerInputState), Member = "SaveDefaultCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CSVWriter), Member = "CloseStreams", ReturnType = typeof(void))]
	public void Close()
	{
		throw null;
	}

	// Token: 0x040000E1 RID: 225
	[global::Cpp2ILInjected.Token(Token = "0x400013A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public byte[] SaveData;

	// Token: 0x040000E2 RID: 226
	[global::Cpp2ILInjected.Token(Token = "0x400013B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private string _outputFile;

	// Token: 0x040000E3 RID: 227
	[global::Cpp2ILInjected.Token(Token = "0x400013C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private bool _open;

	// Token: 0x040000E4 RID: 228
	[global::Cpp2ILInjected.Token(Token = "0x400013D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private StreamWriter _writer;

	// Token: 0x040000E5 RID: 229
	[global::Cpp2ILInjected.Token(Token = "0x400013E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private MemoryStream _memoryStream;
}
