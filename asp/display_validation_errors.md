### Display validation errors

In cshtml view use code below:
```html
<table class="model-state">
    @foreach (var item in ViewContext.ViewData.ModelState) 
    {
        if (item.Value.Errors.Any())
        { 
        <tr>
            <td><b>@item.Key</b></td>
            <td>@((item.Value == null || item.Value.Value == null) ? "<null>" : item.Value.Value.RawValue)</td>
            <td>@(string.Join("; ", item.Value.Errors.Select(x => x.ErrorMessage)))</td>
        </tr>
        }
    }
</table>
<style>
    table.model-state
    {
        border-color: #600;
        border-width: 0 0 1px 1px;
        border-style: solid;
        border-collapse: collapse;
        font-size: .8em;
        font-family: arial;
    }
    table.model-state td
    {
        border-color: #600;
        border-width: 1px 1px 0 0;
        border-style: solid;
        margin: 0;
        padding: .25em .75em;
        background-color: #FFC;
    }
 </style>
```