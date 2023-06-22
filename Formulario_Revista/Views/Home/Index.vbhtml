@Code
    ViewData("Title") = "Home Page"
End Code

<br />
<div>
    <button type="button" class="btn btn-success" data-toggle="collapse" data-target=".navbar-collapse">
        <span class="icon-bar"></span>
    </button>
    @Html.ActionLink("Nuevo", "Crear", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
</div>
<table class="table">
    <thead class="thead-dark">
        <tr>
            <th scope="col">ID</th>
            <th scope="col">Titulo</th>
            <th scope="col">CB</th>
            <th scope="col">Fecha de Circulacion</th>
            <th scope="col">Cat_ID</th>
            <th scope="col">Row_Created</th>
            <th scope="col">Precio</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th scope="row">1</th>
        </tr>
        <tr>
            <th scope="row">2</th>
        </tr>
        <tr>
            <th scope="row">3</th>
        </tr>
    </tbody>
</table>
