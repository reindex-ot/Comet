# Managed Disk Cleanup
![Logo](https://i.imgur.com/RFB7RjN.png)

このプロジェクトは、Windows に同梱しているディスククリーンアップのようなプログラムの再現とユーザー体験を目的としています。オープンソースで開発、無料で利用ができます。ディスククリーンアップは1997年の公開以来、構造は殆ど変化していません。ですが、ディスククリーンアップは後に廃止をする方向になりました(Windows 11 22H2から項目が消えています)
Managed Disk Cleanup はEmptyVolumeCache API の内部動作について学ぶために利用することができます。

このプロジェクトを始めた動機の1つは、コマンドライン引数でディスククリーンアップを使用しないで、クリーンアップを行いたい物を正確にクリーンアップするスクリプトまたはプログラムの作成の可能性が開けた事です。

将来のリリースのための目標:

  - Introduce Restore Point cleanup (Disk Cleanup offers this in its second tab in Administrator mode)
  - Command line-only mode -- intended for better automation, with granular progress reporting
  - An improved system for remembering which categories you've selected (currently mimics Disk Cleanup)
  - Create a repository with a ready-made example for utilizing the API outside of a GUI

## Incompatibilities
Windows 8 introduced changes to the "Data Driven Cleaner" object that are essential for it to work under C#. This is a generic cleanup handler utilized by a handful of the offered cleanup categories. As a result, users using Windows 7 or an earlier OS will be met with a message informing them of limited functionality at startup.

## Reporting errors or bugs
If you happen to run into any of these, filing an issue here will be the most helpful. Besides describing the problem itself, please also include:
 - Your system version (ideally the build number from winver)
 - Your current system locale
 - Whether you were running the program as Administrator

## Suggesting features / providing feedback
In case you'd like to share a suggestion, reaching out to me on [Twitter](https://twitter.com/thebookisclosed) would be the best.
