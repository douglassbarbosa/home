async function getData() {
    const res = await fetch('http://localhost:5271/api/CategoriaCliente')
   
    if (!res.ok) {
      // This will activate the closest `error.js` Error Boundary
      throw new Error('Failed to fetch data, contact your administrator Douglas@gmail.com');
    }
    
    return res.json()
  }
   
  export default async function CategoryList() {
    const categorias = await getData()
   
    return (
        <main>
            <h3>Categorias:</h3>
          {}
          <ul className="category-list">
            {categorias.map((categoria) => (
              <li key={categoria.id} className="category-item">{categoria.nome}</li>
            ))}
          </ul>
        </main>
      );
  }
