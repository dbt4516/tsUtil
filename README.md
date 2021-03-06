# Windows时间戳插件

## 下载
![](https://github.com/dbt4516/tsUtil/blob/master/raw/snap3-copy.png)  
下载链接：https://github.com/dbt4516/tsUtil/blob/master/TsUtil.exe<br>
## 功能点
### 1 时间戳 -> 时间提示
#### 使用方法：
复制想要转换的时间戳，即可在屏幕上看到其对应的时间。提示文本将在显示三秒后消失。<br>
#### 示例：
![](https://github.com/dbt4516/tsUtil/blob/master/raw/snap1.png)  
#### 处理逻辑说明：
监听系统剪贴板，若剪贴板内为10位或13位时间戳则进行显示。<br>
提示文本将显示在当前鼠标指针上方50px的位置，如果鼠标在边缘则会自动调整。<br>
### 2 时间 -> 时间戳快速转换
#### 示例：
在小框中输入1852，按下__回车键__，插件会自动将今天18时52分00秒对应的时间戳写入系统剪贴板（方便用户接续操作），并在小框中回显yyyy-MM-dd HH:mm:ss字符串供用户核验。<br>
如下图按下回车后，当天18时52分00秒的时间戳就会进入剪贴板。<br>
![](https://github.com/dbt4516/tsUtil/blob/master/raw/snap4.png)  
#### 时间输入说明：
输入201608211232 -> 按下回车 -> 2016年8月21日12时32分0秒的时间戳将写入系统剪贴板，并在小框中回显时间字串。<br>
输入08211232 -> 按下回车 -> {当年}8月21日12时13分0秒的时间戳将写入系统剪贴板，并在小框中回显时间字串。<br>
输入211232 -> 按下回车 -> {当月}21日12时32分0秒的时间戳将写入系统剪贴板，并在小框中回显时间字串。<br>
输入1232 -> 按下回车 -> {当日}12时32分0秒的时间戳将写入系统剪贴板，并在小框中回显时间字串。<br>
输入32 -> 按下回车 -> {当前小时}32分0秒的时间戳将写入系统剪贴板，并在小框中回显时间字串。<br>
#### 也可指定秒位，规则示例：
输入1232.1 -> 按下回车 -> {当日}12时32分10秒的时间戳将写入系统剪贴板，并在小框中回显时间字串。<br>
输入1232.35 -> 按下回车 -> {当日}12时32分35秒的时间戳将写入系统剪贴板，并在小框中回显时间字串。<br>
#### 其他提示：
由于插件一般情况下都是隐藏的，此时可点击托盘中的按钮将令其显示，再点击一下就能隐藏。<br>
![](https://github.com/dbt4516/tsUtil/blob/master/raw/snap2 - copy.png)
## 开发背景及改进点
### 背景
近来发现自己也好老大也好工作中时常需要做时间戳转换，流程繁琐，一般需要这样做：<br>
>1）在数据库中选择复制一个时间戳<br>
>2）打开浏览器<br>
>3）切换到在线时间戳转换工具页面<br>
>4）粘贴时间戳<br>
>5）点击按钮查看结果<br>

### 改进点
使用本插件后只需做第一步。<br>
### 背景2
根据QOSS组的工作特点，一般还会有给定时间，拿对应时间戳的需求，这个操作在页面上就更加繁琐：<br>
>1）按照指定格式输入时间（常常要月日都输一遍）<br>
>2）点击转换<br>
>3）复制转换好的时间戳，进行后继操作<br>

### 改进点2
使用本插件后只需做第一步，并且可以不输入年月日（根据QOSS组的工作特点，这可能是最常见的操作），直接取当天指定时分的时间戳，回车之后时间戳直接进入剪贴板，可以快速进入后续操作。<br>
## 开发思路
主要有三项：<br>
* 尽量简洁的UI：目前已经精简到无法再精简<br>
* 尽量压缩操作步骤：体现在呼出插件时文本已经被选中并处于输入状态，用户可以直接输入想要转换的时间，而不用把原先的文本删除再输入。转换后时间戳直接进剪贴板，时间格式多种适配也是基于此考虑。<br>
* 窗体只在该出现的时候出现：所以有自动隐藏、剪贴板内为时间戳就自动显示的功能。使用功能2时怎样让用户呼出插件尝试了几种方式（快捷键/任务栏/隐藏至顶端)，最后发现托盘调用最为干净易用，而且还能加入退出功能。<br>

## 测试
This app has been tested on Thinkpad T440 (Win10) & Dell Latitude 3350 (Win7) with resolution 1360*768.<br>

## 开发日程
* 2016-08-19 确定功能点，调研可行性，安装vs2013（大坑，装了好几遍才装上）
* 2016-08-20 编写代码，几乎不会写C#几乎是一个点一个点谷歌写下来（连怎么退出程序，怎么监听事件都不知道。。）；闲时呼出调整了多次方案。
* 2016-08-21 细节调整，整理文档，上传github。

## On Last
Arber向来鄙夷做app，如果他知道我花了一天多的时间写了个这估计又要说我不务正业浪费时间了，赶紧卸载vs压压惊。<br>
我现在做不来技术改变世界，但或许可以花些功夫改变细节。<br>
希望能给大家（尤其老大）一点点方便。<br>
<br>
## Copyright & Donation
This project is powered by QOSS zyl, whz. <br>
如果觉得本项目还不错，欢迎捐款至支付宝账号 18559621964 鼓励作者。<br>
You are encouraged to donate to Alipay account 18559621964 to make this project better.<br>
新浪微博：palx <br><br>
hongzhan<br>
2016-08-21 in Xiamen Fujian<br>
