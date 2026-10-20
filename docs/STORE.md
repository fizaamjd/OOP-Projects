# Store management

Windows Forms application with admin/customer roles. Business objects are in `userBL` and `stockBL`, persistence is in `userDL` and `stockDL`, and the interface is in `Forms`.

Admin screens cover password changes, stock insertion, retail/cost price changes, quantity changes, date-added lookup, product/stock deletion and available-stock views. Customer screens cover browsing and shopping workflows.

Build with Visual Studio on Windows. Demo text files are copied beside the executable. Run without real account information: this original coursework stores passwords in plaintext and persists data in local comma-separated files. Back up demo files before editing stock.

Manual check: launch, sign in as DemoAdmin, add a product, view stock, update quantity, restart and confirm persistence. Then sign in as DemoCustomer and inspect the available customer actions. No Windows execution is claimed on the macOS maintenance host.
