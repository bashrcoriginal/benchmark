using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace System.Text.RegularExpressions.Generated;

[GeneratedCode("System.Text.RegularExpressions.Generator", "8.0.10.11423")]
internal sealed class <RegexGenerator_g>F6DD43EEA644F37FBD420BF6C4F76D7CBF00A201A3A5DFAA2DE4DAED4B5EFB477__SydPrefix_0 : Regex
{
    private sealed class RunnerFactory : RegexRunnerFactory
    {
        private sealed class Runner : RegexRunner
        {
            protected override void Scan(ReadOnlySpan<char> inputSpan)
            {
                while (TryFindNextPossibleStartingPosition(inputSpan) && !TryMatchAtCurrentPosition(inputSpan) && runtextpos != inputSpan.Length)
                {
                    runtextpos++;
                    if (<RegexGenerator_g>F6DD43EEA644F37FBD420BF6C4F76D7CBF00A201A3A5DFAA2DE4DAED4B5EFB477__Utilities.s_hasTimeout)
                    {
                        CheckTimeout();
                    }
                }
            }

            private bool TryFindNextPossibleStartingPosition(ReadOnlySpan<char> inputSpan)
            {
                int num = runtextpos;
                if (num <= inputSpan.Length - 4)
                {
                    int num2 = inputSpan.Slice(num).IndexOf("syd", StringComparison.OrdinalIgnoreCase);
                    if (num2 >= 0)
                    {
                        runtextpos = num + num2;
                        return true;
                    }
                }
                runtextpos = inputSpan.Length;
                return false;
            }

            private bool TryMatchAtCurrentPosition(ReadOnlySpan<char> inputSpan)
            {
                int num = runtextpos;
                int start = num;
                int num2 = 0;
                int num3 = 0;
                int num4 = 0;
                int num5 = 0;
                int num6 = 0;
                int pos = 0;
                int num7 = 0;
                ReadOnlySpan<char> span = inputSpan.Slice(num);
                if ((uint)span.Length < 3u || !span.StartsWith("syd", StringComparison.OrdinalIgnoreCase))
                {
                    UncaptureUntil(0);
                    return false;
                }
                num += 3;
                span = inputSpan.Slice(num);
                num2 = num;
                num4 = num;
                int i;
                for (i = 0; (uint)i < (uint)span.Length; i++)
                {
                    char c;
                    if ((((c = span[i]) < '\u0080') ? ("\0\0\u0001߿\ufffe蟿\ufffe߿"[(int)c >> 4] & (1 << (c & 0xF))) : (RegexRunner.CharInClass(c, "\0\f\0 !0;A[_`a{KÅ") ? 1 : 0)) == 0)
                    {
                        break;
                    }
                }
                if (i == 0)
                {
                    UncaptureUntil(0);
                    return false;
                }
                span = span.Slice(i);
                num += i;
                num5 = num;
                num4++;
                while (true)
                {
                    num3 = Crawlpos();
                    Capture(1, num2, num);
                    num7 = pos;
                    num6 = 0;
                    while (true)
                    {
                        <RegexGenerator_g>F6DD43EEA644F37FBD420BF6C4F76D7CBF00A201A3A5DFAA2DE4DAED4B5EFB477__Utilities.StackPush(ref runstack, ref pos, Crawlpos(), num);
                        num6++;
                        int start2 = num;
                        if (!span.IsEmpty && span[0] == ',')
                        {
                            num++;
                            span = inputSpan.Slice(num);
                            Capture(2, start2, num);
                            if (num6 == 0)
                            {
                                continue;
                            }
                        }
                        else
                        {
                            if (--num6 < 0)
                            {
                                break;
                            }
                            num = runstack[--pos];
                            UncaptureUntil(runstack[--pos]);
                            span = inputSpan.Slice(num);
                        }
                        pos = num7;
                        runtextpos = num;
                        Capture(0, start, num);
                        return true;
                    }
                    UncaptureUntil(num3);
                    if (<RegexGenerator_g>F6DD43EEA644F37FBD420BF6C4F76D7CBF00A201A3A5DFAA2DE4DAED4B5EFB477__Utilities.s_hasTimeout)
                    {
                        CheckTimeout();
                    }
                    if (num4 >= num5)
                    {
                        break;
                    }
                    num = --num5;
                    span = inputSpan.Slice(num);
                }
                UncaptureUntil(0);
                return false;
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                void UncaptureUntil(int capturePosition)
                {
                    while (Crawlpos() > capturePosition)
                    {
                        Uncapture();
                    }
                }
            }
        }

        protected override RegexRunner CreateInstance()
        {
            return new Runner();
        }
    }

    internal static readonly <RegexGenerator_g>F6DD43EEA644F37FBD420BF6C4F76D7CBF00A201A3A5DFAA2DE4DAED4B5EFB477__SydPrefix_0 Instance = new <RegexGenerator_g>F6DD43EEA644F37FBD420BF6C4F76D7CBF00A201A3A5DFAA2DE4DAED4B5EFB477__SydPrefix_0();

    private <RegexGenerator_g>F6DD43EEA644F37FBD420BF6C4F76D7CBF00A201A3A5DFAA2DE4DAED4B5EFB477__SydPrefix_0()
    {
        pattern = "syd([a-zA-Z0-9 _:]+)(,)?";
        roptions = RegexOptions.IgnoreCase | RegexOptions.Singleline;
        Regex.ValidateMatchTimeout(<RegexGenerator_g>F6DD43EEA644F37FBD420BF6C4F76D7CBF00A201A3A5DFAA2DE4DAED4B5EFB477__Utilities.s_defaultTimeout);
        internalMatchTimeout = <RegexGenerator_g>F6DD43EEA644F37FBD420BF6C4F76D7CBF00A201A3A5DFAA2DE4DAED4B5EFB477__Utilities.s_defaultTimeout;
        factory = new RunnerFactory();
        capsize = 3;
    }
}
