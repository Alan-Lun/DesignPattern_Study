# Singleton (單例/獨體模式)

Singleton不適合繼承
確保類別只有一個物件實體存在
一直產生執行個體會導致GC

Double-locking


# Registry of Singleton 又稱Multiton pattern
管理一群不同型別物件，又希望都是單例
透過註冊表達到此需求

變形的Registry singleton 
處理現有沒變成Singleton的
