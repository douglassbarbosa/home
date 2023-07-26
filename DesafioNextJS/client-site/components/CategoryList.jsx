import Link from 'next/link'; 
import AddCategory from '../components/AddCategory'
import RemoveBtn from "./RemoveBtn";



async function getData() {
  const res = await fetch('http://localhost:5271/api/CategoriaCliente', { cache: 'no-store' })

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
      <div className='category-add'>        
      <AddCategory />
      </div>
      <h3>Categorias:</h3> 
      <div>
        <div>
          <ul className="category-list">
            {
            categorias.map((categoria) => (
            <li key={categoria.id} className="category-item">
              {categoria.nome}
              <div className="button-container">
                <Link href={`./edit/${categoria.id}`} className="edit-button">
                  EDITAR
                </Link>                 
                <RemoveBtn id={categoria.id} /> 
              </div>
            </li>
            ))}   
          </ul>
        </div>
      </div>
      
      
    </main>
  );
}
