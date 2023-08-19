'use client'
import React, { useEffect, useState } from 'react';
import Link from 'next/link';
import AddCategory from '../components/AddCategory';
import RemoveBtn from './RemoveBtn';



export default function CategoryList() {
  const [_categorias, setCategorias] = useState([]);

  async function getData() {
    const res = await fetch('http://localhost:5271/api/CategoriaCliente', { cache: 'no-store' });

    if (!res.ok) {
      throw new Error('Failed to fetch data, contact your administrator Douglas@gmail.com');
    }

    return res.json();
  }
  useEffect(() => {
 
    const fetchData = async () => {
      try {

        const categoriasData = await getData();
        setCategorias(categoriasData); 

        console.log('Dados obtidos:', categoriasData);
      } catch (error) {
        console.error('Erro ao obter dados:', error);
      }
    };

    fetchData();
  }, [_categorias]);

  return (
    <main>
      <div className='category-add'>
        <AddCategory />
      </div>
      <h3>Categorias:</h3>
      <div>
        <div>
          <ul className="category-list">
            {_categorias.map((categoria) => (
              <li key={categoria.id} className="category-item">

                {categoria.nome}

                <div className="button-container">

                  <Link href={`/edit/${categoria.id}`} className="edit-button">
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
