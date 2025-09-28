# Mini Marketplace Manager (C# WinForms)

A Windows Forms desktop app that models a simple marketplace. You can add sellers and buyers, create items (with categories like Kids/Electric/Office/Clothing), list a seller’s items for sale, record a buyer’s purchase from a selected seller, and view summarized info for all buyers/sellers. It demonstrates clean object modeling in C# (classes for User, Buyer, Seller, Item, Address), WinForms UI flows (multi-step “add item to seller/buyer” dialogs), robust input validation (regex/typed checks), and basic text-file persistence for seller data.
---

## Features

- **Users & Roles**
  - Create **Sellers** (with name, address, contact)
  - Create **Buyers** (with name, address, contact)
- **Inventory**
  - Add **Items** to a seller (name, category, price, quantity)
  - Categories include common types (Kids, Electric, Office, Clothing, …)
- **Transactions**
  - Select a **Seller → Item → Buyer** and record a **purchase**
  - Automatically adjust stock and log the sale
- **Views & Summaries**
  - List a seller’s items for sale
  - Summaries of buyers, sellers, purchases
- **Validation & UX**
  - Typed input and regex validation for robust forms
- **Persistence**
  - Simple text-file storage to keep seller/inventory data between runs
