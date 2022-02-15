# Unity TestFramework を試す

Unityでのテストを試してみる。  

## ざっくり内容

MV(R)Pで用意したUIのテストをEditModeとPlayModeでそれぞれテスト。

## テスト方法

1. Window -> General -> TestRunner
2. EditMode or PlayModeを選択
3. RunAll

## その他

単体テストが可能な状態を維持したい=Interfaceを用意して実施するべきだが、  
保守コストが上がるので状況に応じて対応するべき。  
`※ガバレッジ100%目指しても、結局テストコードの品質に依存するし..。`  
`※Googleさんも目標85%だし...。`  

## 感想

便利。安心感+。