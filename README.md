
#Firstly compile the source file using 

csc.exe /platform:anycpu /target:library /unsafe demo.cs

# disassemble demo.dll and make a demo.il file.

ildasm.exe /out:demo.il demo.dll

# Edit demo.il and find the section === CLASS MEMBERS, look for the Exec method and insert .export [1] to make an entrypoint

# Recompile it

ilasm.exe demo.il /DLL /output=demo.dll

# Run the code using, a message displaying hello world should appear in a pop up box.

rundll32 demo.dll Exec 
