open System

// Mapping, Filtering through Lists
let salaries = [75000; 48000; 120000; 190000; 300113; 92000; 36000]

// Function to calculate federal income tax based on salary
let calculateTax salary =
    match salary with
    | s when s <= 49020 -> float s * 0.15
    | s when s <= 98040 -> float s * 0.205
    | s when s <= 151978 -> float s * 0.26
    | s when s <= 216511 -> float s * 0.29
    | _ -> float salary * 0.33

// Filter high-income salaries
let highsalary = salaries |> List.filter (fun s -> s > 100000)

// Calculate tax for all salaries
let calsalarytax = salaries |> List.map calculateTax

// Add $20,000 to salaries less than $49,020
let adjustedSalaries = salaries |> List.map (fun s -> if s < 49020 then s + 20000 else s)

// Sum salaries between $50,000 and $100,000
let Salarytotal = salaries |> List.filter (fun s -> s >= 50000 && s <= 100000) |> List.sum

// Tail Recursion
let rec sum_multiple_three n acc =
    if n = 0 then acc
    else sum_multiple_three (n - 3) (acc + n)

// Test Tail Recursion function
let result = sum_multiple_three 27 0

// Output results
printfn "High-Income Salaries: %A" highsalary
printfn "Taxes for each salary: %A" calsalarytax
printfn "Adjusted Salaries: %A" adjustedSalaries
printfn "Total Salary Sum between $50,000 and $100,000: %d" Salarytotal
printfn "Sum of Multiples of Three up to 27: %d" result
