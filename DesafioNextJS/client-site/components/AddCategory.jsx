"use client";

import { useState } from "react";
import { useRouter } from "next/navigation";

export default function AddCategory(){
  const [nome, setNome] = useState("");

  const router = useRouter();

  const handleSubmit = async (e) => {
      e.preventDefault();

      if (!nome ) {
        alert("Insira um nome para Categoria");
        return;
      }
      
      try {
        const response = await fetch('http://localhost:5271/api/CategoriaCliente'  , {
          method: 'POST',
          headers: {
            'Content-Type': 'application/json',
          },
          body: JSON.stringify({nome}),
        });
        
        if (response.ok) {
          console.log('Categoria adicionada com sucesso!'); 
          router.refresh('/categorias');
          setNome('');

        } else { 
          console.error('Erro ao adicionar categoria');
        }
      } catch (error) { 
        console.error('Ocorreu um erro inesperado', error);
      }
    };
     
  
  return (
    <form onSubmit={handleSubmit} className="input-container-ADD">
      <div>
        <p>Adicionar nova categoria:</p>
      <div className="input-container-add">
        <input 
          onChange = {(e) => setNome(e.target.value)}
          value={nome} 
          type="text" 
          placeholder="Digite aqui para adicionar..."
        />
      </div>
      <button title="" type="submit" className="addCategory">
        ADICIONAR
      </button>
      </div>
    </form>
  );
};

  