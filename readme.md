# txt2unix

All it does is convert CRLF with LF, so all files are set to the Unix standard.
Please note, this does not work properly with non UTF-8 files. The tool does try to block out binary files, but the results can be kinda funny!

When used on a unix system with Mono wild cards can work (because unix takes care of them by itself and doesn't need the apps to do that), in Windows, no!

I do recommend to backup prior to using this tool, to make sure any "damage" caused by wrong usage can be "repaired".
