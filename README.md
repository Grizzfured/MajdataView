# MajdataView&Edit

![Majdata Festival](https://img.shields.io/badge/Majdata-FESTiVAL-ff69b4)
![version v4.0-rc](https://img.shields.io/badge/version-v4.0--rc-green)
![license GPL-3.0](https://img.shields.io/badge/license-GPL--3.0-blue)
[![State-of-the-art Shitcode](https://img.shields.io/static/v1?label=State-of-the-art&message=Shitcode&color=7B5804)](https://github.com/trekhleb/state-of-the-art-shitcode)

## Credits

- Main Programmer: bbben([>Twitter](https://twitter.com/bbben132329)), [Moying-moe](https://github.com/Moying-moe/maimaiMuriDetector)
- Mirroring: [Wh1tyEnd](https://github.com/Wh1tyEnd)
- Hanabi Effect: 青山散人
- *Special thanks*: Simai developed by [Celeca](https://twitter.com/formiku39854)

## 语言切换方法/言語切り替え方法/How to change language

- 使用设置菜单
- 設定メニューをご利用して下さい
- Please use the setting menu.

## 使用指南

双击文件夹中的`MajdataEdit.exe`（简称Edit）打开软件，看谱器`MajdataView`（简称view）会**自动打开**。然后在Edit中新建或打开一个谱面。

主界面底部是时间轴，上面的文本框为写谱的地方，左边有播放、停止按钮以及时间显示等。

用**鼠标滚轮**或**鼠标拖动**可以调整**底部时间轴**的时间。按住**Ctrl**点击文本可以快速移动时间轴到指定位置。

使用maidata语法写谱，语法可参照simai_wiki（[点击此处打开](https://w.atwiki.jp/simai/pages/25.html)）。中文教程正在编写中。

选中一部分谱面文本，然后点击`编辑`中的几种翻转按钮，可以**一键镜像翻转**或**旋转**被选中的谱面。

点击**播放**（三角图标）可以从当前时间轴位置开始预览谱面，**推荐在写谱时使用**。点击**录制模式**会从头开始播放谱面，并且会播放开始动画和AP动画，**推荐录制视频时使用**。

`设置->重新对准编辑器窗口`可以让View移动到编辑器的左边位置。

在`设置->编辑器设置`中可以设置**谱面流速、背景暗度等**。

在`设置->音量`中可以设置当前谱面的每种note音效的音量。

在`编辑->谱面信息`中可以设置**曲名、曲师、谱师、封面**和其他&参数。

谱面同文件夹中，`bg.jpg`或`bg.png`将会作为谱面的**封面**。而`bg.mp4`、`mv.mp4`或`bg.wmv`则是**背景动画**（背景视频），不过**这不是必须的**，如果没有，那么将会使用封面作为背景。

在`编辑谱面信息->Other Commands`里面可以设置歌曲开始前的节拍提示，输入: `&clock_count=4`，这表示表示开头响4下。节拍提示**只在录制模式下有效**。

点击菜单栏的`检查更新`，可以检查您的Majdata是否为最新版本。如果不是，会帮您打开下载页面。

## 其他功能

1. 可以更换**皮肤**（Skin文件夹）和**音效**（SFX文件夹），具体见下文
2. 可以更改字号，具体见下文`EditorSetting.json`部分
3. View中间偏右上角有隐藏按钮（鼠标移过去可以看到），可以切换combo显示和全屏等
4. 已对应maipad变速语法 <HS*1.0>
5. 已支持FESTiVAL新要素，详情请见下文的**FESTiVAL新语法**部分。

## 快捷键列表

把**焦点放在文本框中**这些快捷键才能起作用。

|快捷键|功能|备注|
|--|--|--|
|Ctrl+鼠标左键/方向键|选定进度| |
|Ctrl+S|保存| |
|Ctrl+Z|撤销| |
|Ctrl+Shift+C|播放/停止|适用于在写谱时重复听一个段落的情况|
|Ctrl+Shift+X|播放/暂停|适用于总览谱面的情况|
|Ctrl+Shift+Z|录制模式| |
|Ctrl+p|加快播放速度| |
|Ctrl+o|减缓播放速度|对音用|
|Ctrl+J|左右镜像|对选中文本实施，下同
|Ctrl+K|上下镜像| |
|Ctrl+L|180°旋转| |
|Ctrl+;|顺时针45°旋转| |
|Ctrl+'|逆时针45°旋转| |

要更改快捷键的话，请编辑EditorSetting.json（见下文）

有关键位名称请参阅 [这里](https://docs.microsoft.com/zh-cn/dotnet/api/system.windows.input.key)

## EditorSetting设置

在文件夹下有一个叫`EditorSetting.json`的文件（根据您电脑的设置，您有可能看不到`.json`的后缀）。您可以使用**记事本**或者其他文本编辑软件打开。

打开后，您可以看到一行一行的设置。**大部分设置都可以在编辑器中直接修改**，不需要您专门打开文件来修改。但是**有一些设置，必须要手动编辑**。

### 自动更新设置

在每次您打开Majdata的时候，都会自动检查您的Majdata是否为最新版本。

如果您使用的是**最新版**，或者您的**网络不可用**，则**不会发出任何提示**。

不过，如果您想使用某一个旧版本，并且不想被自动更新检查打扰，您可以您可以打开**编辑器设置**，然后禁用这个功能。

### 撞尾检测默认精度

在Majdata的菜单栏中点击`工具->无理检测`，可以打开无理检测工具，帮助您检查您的谱面是否存在错误的内容。

在这个功能中，默认的撞尾检测精度是`0.2`（具体含义可将鼠标放在**这是什么**上查看）。

您可以打开Majdata目录下的`EditorSetting.json`文件，找到以下行：

```json
...
  "DefaultSlideAccuracy": 0.2,
...
```

将上文中的`0.2`修改为其他数值，如`0.15`（更宽松的检测）、`0.25`（更严格的检测）。

当然，打开无理检测工具后，**您其实也可以手动修改这个数值，只不过在下次打开时又会恢复到默认值**。

### 快捷键设定

上文提及的快捷键均可设置成自己喜欢的。

```json
...
  "PlayPauseKey": "Ctrl+Shift+c",
  "PlayStopKey": "Ctrl+Shift+x",
  "SendViewerKey": "Ctrl+Shift+z",
  "SaveKey": "Ctrl+s",
  "IncreasePlaybackSpeedKey": "Ctrl+p",
  "DecreasePlaybackSpeedKey": "Ctrl+o",
...
```

您可以修改上文中**后面引号里的内容**。

举例来说，您想把**录制模式**的快捷键改为Ctrl+U，您就需要将

```json
  "SendViewerKey": "Ctrl+Shift+z",
```

改为

```json
  "SendViewerKey": "Ctrl+u",
```

**请注意不要将引号以及结尾的逗号删除！**

除了所有的字母按键以外，一些键位的名称可能并非直觉上的那样（如分号键是`OemSemicolon`而不是`;`），您可以参考[这篇文档](https://docs.microsoft.com/zh-cn/dotnet/api/system.windows.input.key)。

### 字体大小

```json
...
  "FontSize": 12.0,
...
```

您可以修改编辑器中所有字体的大小，将上文中的`12.0`修改为任何想要的数字即可。

## 我在使用过程中遇到了问题

如果您在使用过程中遇到了问题，**请先对照下文的Q&A中列出的常见问题进行排查**。

如果未找到您遇到的问题，亦或是按照其中的解决方案仍无法解决，**请按照以下步骤将您遇到的问题汇报给我们**，我们的社区维护者会在看到您的汇报后尽快排查并解决此问题。

1. 请先确认，您遇到的是一个报错，还是一个不正常情况；
   - 如果您看到了错误信息弹窗，这说明您遇到的是一个*报错*。**请将此弹窗截图保存**；
   - 如果您觉得软件运行的不正常，如：应该得到结果A，但是实际上却是结果B。这说明您遇到的是一个*不正常情况*。**请记下您遇到的不正常情况**；
2. 回忆出现问题之前，您正在做什么；
3. 打开浏览器，进入[Majdata的issue页面](https://github.com/LingFeng-bbben/MajdataView/issues)，点击右上角的**New issue**，选择**提交BUG(中文)**模板；
   - 如果您没有Github账号，可能会提示您登录或注册一个新的账号；
4. 按照模板中的提示，填写信息，并提交。在您提交的issue中，附带上您的截图以及**尽可能详尽的描述**。

在提交您的问题时，请注意以下几点：

- **尽可能详尽的描述您的操作**。我们知道绝大部分的使用者并非专业人士，因此，如果您说了很多废话，我们的社区维护者并不会怪罪您，并可以很轻松的忽略掉没用的那部分。**但是如果您说的太少，那么维护者还需要反复与您沟通，这会浪费很多时间与精力**。
- **尝试重复这个问题**。如果您可以通过某些操作稳定的触发这个问题，您可以将您的这些操作写下来，**这十分有帮助**。同样的，如果您重复之前遇到这个问题的操作，结果发现问题消失了，也请告诉我们这一点。
- **如果情况十分难以描述，您可以附上截图或者视频作为辅助**。此外，您最好可以将出现问题时您正在编辑的谱面也一起发给我们。

## Q&A

### 为什么软件无法启动？

- 请确认您安装了`.net Framework 4.7.2`
- 如果打开报错与PresentationCore有关，请尝试强制软件渲染

### 报错提示“未将对象引用设置到对象的实例”

- 请确保Majdata软件以及您的谱面均位于您的用户拥有权限的文件夹。比如：您将谱面文件放在`C:\Users\p'c\AppData\Local\`，将Majdata本体放在C盘根目录下，**都可能导致此问题**。
- 如果仍然无法解决，请确认您在Windows系统中目前使用的用户是否为**超级管理员**（一般而言您应当是），并尝试**以管理员身份运行**Majdata。
- 如果仍然无法解决，请按照报错信息提交部分的提示汇报您遇到的问题。

### 为什么我的谱面无法打开？（很长很吓人的报错）

- 如果报错信息开头几行有**ReadWaveFromFile**字样，请确认您的mp3文件为**固定比特率**。
- 本软件只读取&title，&artist，&des，&first，&lv_x和&inote_x字段，请删掉其他字段和空字段重试。

### 延迟很大/音乐谱面对不上

- 请尝试更改您的时区
- 请不要在谱面中长时间使用一种拍号
- 请确保您的mp3文件为标准比特率。具体请看 [这里](https://github.com/LingFeng-bbben/MajdataEdit/issues/26)

### 怎么录谱面的视频？

- **Majdata没有录屏功能**
- 请把鼠标移动到view的右上角，点击全屏按钮，打开您的录制软件并开始录制，然后点击edit中的**录制模式**按钮
- 推荐您使用Geforce Experience进行录制，也可以使用OBS Studio录制。

### 我的封面无法加载

- 请确认您的封面比例为1：1。推荐的分辨率是1080x1080

### 我想全屏View/我想查看谱面物量

- 右上角有隐藏的全屏按钮，鼠标悬浮即可显示
- 还有一键拓宽按钮

### 为什么该重合的星星没有完全重合？

- 因为所有slide都是手动放置的，可能存在轻微的误差

### 我对xxx音效不满意

- 您可以修改SFX文件夹内的音效文件

### 我对xxx外观不满意

- 您可以修改SFX文件夹内的皮肤文件

### 能用Majdata来画画吗

- 滚

### 能写Phixxos的谱吗

- 滚

### 我是第一次写maimai谱面，该怎么做?

1. 请先选好歌，剪辑好长度后新建文件夹，并把歌曲重命名为track.mp3
2. 请点击新建，然后在编辑->一般谱面信息中，设置好谱面信息
3. 请设置背景，将（bg.mp4/bg.wmv/bg.jpg/bg.png）文件存入和track.mp3一个文件夹内
4. 请打开SimaiWiki（日语），熟悉各种note的摆放方式和语法
5. 请使用工具中的BPMtap或其他软件测试好歌曲bpm
6. 请使用偏移来对准小节线

## FESTiVAL新语法

### 组合Slide

组合Slide是将多根**子Slide**组合起来的新要素。例子如下：

```plain
1v3-5[4:1],
2b-4^5-1-7[2:1],
```

每一条新组合上去的**子Slide**，都需要首尾相接的写在上一条的后面，**起点无需重复书写**。比如说，`1v3-5[4:1]`就是由`1v3`和`3-5`组合而成的。

语法中最后的时间指定了**整条**组合Slide的时间，这是一般而言情况下的写法。

当然，您也可以指定每一条Slide的时长。

```plain
4qq4[4:1]z8[2:1],
2b-4[4:1]^5[8:1]-1[4:1]-7[4:1],
```

如果这样写，那么就必须指定**每一条**Slide的时长，不可以一部分指定，一部分不指定（如`1-4-6[4:1]-1[4:1]`是不允许的）。

此外，在这种写法下，BPM的特殊指定语法只会影响整条组合Slide的启动时间，**组合Slide中的每一条子Slide仍然会首尾相接的滑动**。

如`(120){4}1-4[60#8:1]-7[60#8:1]-2[4:1],`，整条组合Slide会延迟两拍以后启动，不停顿的走完全程。第二段的`-7[60#8:1]`完全等价于`-7[4:1]`，而不会产生停顿效果。

如果需要为星星头标记break或ex，则需要写在第一个数字（也即组合Slide的起点）之后，如上面的例2。

组合Slide可以和同头Slide一起使用，但是您必须**完整的书写每一条星星**。比如，您希望让Slide从1到5，然后在5的位置分开，分别到2和8，那么您应该书写`1-5-2[2:1]*-5-8[2:1]`（而不是`1-5-2*-8[2:1]`）

### Break拓展

新版本中，Break、Ex、Hold可以彼此共存，出现如**Break Hold**、**Ex Break**、**Ex Break Star**等种类的note。它们的语法和过去类似，只不过可以相互叠加。如：

```plain
1bh[4:1],
1bxh,
1bx-5[8:1],
```

尽管这些标记的书写顺序并无强制要求，但是仍然强烈建议您以以下的顺序优先级书写：

`b x h`

### Break Slide

Break Slide是指，Slide的滑条部分是*Break*的。

您应当将b书写在Slide时长之前（Majdata语法），当然也兼容Simai语法，即写在时长之后。

```plain
2^7b[4:1],
2^7[4:1]b,
1bv3-5b[4:1],
```

您可能注意到，上面的例3中，出现了两个b，其中，第一个b指定了星星头（Slide-Tap）为Break，第二个b指定了Slide为Break。换言之，**Break Slide并不一定有一个绝赞星星头**。

### Touch拓展

在新版本中，您可以将Touch书写在A区与D区上。

```plain
A1,
D3,
```

同时，任何一个Touch都可以附加烟花，语法与过去类似。

```plain
A1f,
D3f,
```

## 已知问题

1. **不支持动态比特率的mp3文件**
2. 暂不支持Touch、Wifi等要素的皮肤定制
3. 部分语法规则较为宽松，可以在Majdata中运行的谱面可能无法在其他软件中（如maipad、simai）运行

其他问题见[issue页面](https://github.com/LingFeng-bbben/MajdataView/issues)

## 皮肤Skin文件夹对照表

*动动手 动动脑 你一定能找到你的需要*

|文件名|备注|
|--|--|
|outline.png
|tap.png
|tap_each.png
|tap_break.png
|tap_ex.png|ex是白色的外圈发光贴图|
|slide.png
|slide_each.png
|slide_break.png|FESTiVAL版本新增|
|star.png|请确保旋转中心和图像中心重合|
|star_double.png
|star_each.png
|star_each_double.png
|star_break.png
|star_break_double.png
|star_ex.png
|star_ex_double.png
|hold.png|上下切图的像素距离为58|
|hold_each.png
|hold_ex.png
|hold_break.png|FESTiVAL版本新增|
|just_curv_l.png|以下六个是星星判定图 不需要可以直接删|
|just_curv_r.png
|just_str_l.png
|just_str_r.png
|just_wifi_u.png
|just_wifi_d.png

## 音效SFX文件夹对照表

|文件名|备注|
|-|-|
|all_perfect.wav
|answer.wav|即官方的“正解音”，它听起来就像是“哒”|
|judge.wav|普通note的判定音，它听起来就像是“铛”|
|judge_break.wav|Break的判定音|
|judge_ex.wav|Ex-Note的判定音|
|break.wav|Break达到理论值时的欢呼声|
|clock.wav|开头的节拍提示音|
|hanabi.wav|Touch的烟花音效|
|slide.wav
|touch.wav
|touchHold_riser.wav|TouchHold按住的音效|
|track_start.wav|开始播放的音效|
