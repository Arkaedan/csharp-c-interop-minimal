# C#-C Interop MVP

Minimal example showing C interop with C#

Setup (Ubuntu):
```sh
sudo apt install gcc dotnet-sdk-8.0
```

Compile C:
```sh
gcc -shared -o lib.so -fPIC lib.c
```

Run:
```sh
dotnet run
```