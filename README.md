# projectFrameCut.CodecExtendPack
这个扩展提供了额外的带libx264和libx265等基于GPL协议开源的编解码器。支持安卓上的arm64-v8a，和Windows上的x64平台。

Windows端的FFmpeg来自于[Gyan.dev](https://www.gyan.dev/ffmpeg/builds/)

要安装它，在Release里下载，然后在projectFrameCut的设置->插件->添加插件里安装，重启应用程序，再次转到设置->通用->编解码器->'选择FFmpeg库提供者'选择'projectFrameCut codec extend pack'，在重启程序即可。

> [!NOTE]
> 如果你在使用安卓设备，并且在文件选择器里找不到你下载的'.pjfcPlugin'文件，请尝试用文件管理器修改文件的后缀名到'.bin'

# 使用自己的FFmpeg
你可以克隆这个项目，修改projectFrameCut.CodecExtendPack.csproj里的PluginAssetPath，然后编译并且发布来使用你自己的FFmpeg库。
开发插件的入门教材在[这里](https://github.com/hexadecimal0x12e/projectFrameCut.PluginTemplate)。

PluginAssetPath里的目录布局类似于这样子：
```
D:\CODE\PLAYGROUND\FFMPEG\CODECPACK
└─FFmpeg
    ├─android
    │      libavcodec.so
    │      libavfilter.so
    │      libavformat.so
    │      libavutil.so
    │      libc++_shared.so
    │      libswresample.so
    │      libswscale.so
    │
    └─windows
            avcodec-62.dll
            avdevice-62.dll
            avfilter-11.dll
            avformat-62.dll
            avutil-60.dll
            ffmpeg.exe
            ffplay.exe
            ffprobe.exe
            swresample-6.dll
            swscale-9.dll
```

