using System.IO;
using System.Threading.Tasks;

namespace ITBees.Interfaces.Printing;

public interface IPcsEscPosPrinter
{
    void AlignRight();
    void AlignLeft();
    void CutOff(CutMode mode = CutMode.Full);
    void SetLargeBoldFont();
    void SetLargeFont();
    void AddLineToPrintStream(string text);
    void SetMediumBoldFont();
    Task Print(string port);
    void SetCodePage(MemoryStream ms, byte codePageNumber);
    void WriteTextLine(string text, MemoryStream ms);
    void AddEmptyLines(MemoryStream ms, int linesCount);
    void FeedLines(int linesCount);
    void AlignCenter();
    void SetStandardFontWeight();
    void SetStandardFont();
    void SetBoldFont();
    void SetMediumFont();
    void WriteByte(byte[] bytes);
    void Write(byte[] data, int i, int dataLength);
    void Write(byte[] data);
    void WriteCutToBuffer();
    Task FlushToPortAndReset();
    void SetCharSize(byte widthMul = 1, byte heightMul = 1);
    void SetWideOnly(bool enable);
    void ResetLineSpacing();
    void SetLineSpacing(byte dots);
    void SetCharacterSpacing(byte dots);
    void ResetCharacterSpacing();
    void PrintBitmapEscStar24(string path, int targetWidthPx = 384, byte threshold = 160, bool invert = false);
    void PrintBitmapEscStar24v2(string path, int targetWidthPx = 384, byte threshold = 160, bool invert = false);
}