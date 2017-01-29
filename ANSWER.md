# 陳品陵 Ally
## 思維訓練題回答

什麼是Class
* Class內有該類別的屬性和方法，可以讓不同的class繼承。

什麼是Constructor
* 使用new呼叫建立物件。

什麼是Destructor
* 刪掉所建立的物件，釋放記憶體空間。

什麼是Interface
* 類似class，但無法初始化(new)，只能用來繼承。

什麼是Polymorphism 我在哪使用了Polymorphism
* 使用同一個操作介面，以操作不同的物件實例。在 code 中，我創建了一個[CreatureType](https://github.com/AllyChen/AllyPlanet/blob/master/creature.cs#L11)，讓 [class Lion](https://github.com/AllyChen/AllyPlanet/blob/master/Program.cs#L11) 和 [class Plant](https://github.com/AllyChen/AllyPlanet/blob/master/Program.cs#L21)使用。

[什麼是template](https://github.com/bachelorwhc/PlanetEditor/blob/master/creature.h#L20)
* 類似一種模組。寫一種方法，讓不同Type的變數都可以使用該方法。

[`Planet::Planet(const Planet & src)`將會產生什麼問題](https://github.com/bachelorwhc/PlanetEditor/blob/master/planet.cpp#L7)
* null

`std::shared_ptr`是什麼
* 當 new 出來了之後、在沒有指標去指到那塊記憶體空間、又沒有做對應的 delete 的情況下，就會產生「記憶體還是佔在那邊，但是卻沒有辦法使用、也沒辦法釋放」的問題，也就是所謂的「memory leak」。為了要解決這類的問題，C++ 就在 STL 裡面，引進了「Smart Point」的概念。可以有多個 `shared_ptr` 共用一份資源的 smart pointer，內部會記錄這份資源被使用的次數（reference counter），只要還有 `shared_ptr` 物件的存在、資源就不會釋放；只有當所有使用這份資源的 `shared_ptr` 物件都消失的時候，資源才會被自動釋放。

如果忘記釋放記憶體會發生什麼事 C#會發生相同的事嗎
* 不會。c# 有一種自動的記憶體管理機制(garbage collection)。