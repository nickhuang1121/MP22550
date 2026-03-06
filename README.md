# MP22550

這個 repository 用來整理我在撰寫程式教學內容時使用的範例程式，以及一些延伸實作的練習。

目前內容包含書籍章節範例，以及一個較完整的 JavaScript 進階示範專案。

---

## Repository Structure

### Chapter Examples
`2/` 、`3/` 、`4/` 、`5/` 、`6/` 、`7/` 、`8/` 、`9/` 目錄中包含書籍內程式語言基礎教學的範例，並同時提供 **C#** 與 **JavaScript** 版本。
`10/`、`11/` 、`12/` 、`13/` 、`14/` 、`15/` 、`16/` 目錄中包含書籍內實作模擬器對應的範例程式，並同時提供 **C#** 與 **JavaScript** 版本。

範例內容主要用於說明：

- 基礎程式設計概念
- 物件導向設計
- C# 與 JavaScript 的對照寫法
- 程式結構與模組拆分

這些程式主要作為教學用途，因此每個範例都聚焦在單一概念。

---

### JS進階示範

`JS進階示範/` 是一個較完整的實作示例，示範如何使用 JavaScript 建構一個簡單的模擬器架構，包含 CPU 指令解碼、ROM 載入，以及模組化的系統設計。  

此範例包含以下設計重點：

#### 1. Class-based Architecture

主要功能模組皆使用 `class` 建構，例如：

- CPU
- Memory
- 系統控制邏輯

讓整體架構更清晰，也比較接近實際模擬器的設計方式。

---

#### 2. Mnemonic-based Instruction Set

CPU 指令集使用 **助記符 (Mnemonic)** 來實作。

例如：LD、ADD、JP、CALL、RET

透過助記符解析並執行對應的 CPU 行為，  
讓指令集邏輯更容易閱讀與維護。

---

#### 3. ROM Loading

系統可以載入不同的 **ROM 檔案**進行執行。

目前 repository 中包含一些測試用 ROM，例如：

- INVADERS
- BRIX
- PONG
- UFO

使用者可以替換 ROM 來測試不同程式。

---

#### 4. Sound Support

音效部分採用 **播放音訊檔案的方式**實作。

當模擬器觸發聲音事件時，  
系統會播放對應音效，以模擬原始硬體的聲音行為。

---

## Purpose of This Repository

這個 repository 的主要目的：

- 整理書籍教學範例
- 保存程式設計練習過程
- 示範 CPU 模擬器的基本架構
- 比較 C# 與 JavaScript 的程式設計方式

這些程式並不是完整產品，而是偏向 **學習與實驗性質的實作**。

---

## Running the Examples

### C#

可使用 **Visual Studio** 或 **.NET CLI** 開啟並執行對應專案。

### JavaScript

JavaScript 範例可以：

- 直接用瀏覽器開啟
- 或搭配簡單的本地伺服器執行

---

## Author

Nick Huang


