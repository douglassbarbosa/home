"use client"
import React, { useState } from "react";
import { useRouter } from "next/navigation";

async function getCategoriaById(id) {
  console.log("001 -- getCategoriaById  = ", id);

  const res = await fetch(`http://localhost:5271/api/CategoriaCliente/${id}`, {
    method: "GET",
    "no-cache": true,
  });

  if (!res.ok) {
    throw new Error(
      "Failed to fetch data, contact your administrator Douglas@gmail.com"
    );
  }

  return res.json();
}

export default function EditCategory({ id }){
  const [nomecategoria, setNome] = useState(""); 
 
  var router = useRouter();

  React.useEffect(() => {
    const fetchData = async () => {
      try {
        const categoriaEdit = await getCategoriaById(id);
        setNome(categoriaEdit.nome);
      } catch (error) {
        console.error("Ocorreu um erro ao buscar categoria", error);
      }
    };

    fetchData();
  }, [id]);

  const handleChange = (event) => {
    setNome(event.target.value);
  };

  const handleSubmit = async (e) => {
    e.preventDefault();

    if (!nomecategoria) {
      alert("Insira um nome para a categoria");
      return;
    }

    try {
      const response = await fetch(
        `http://localhost:5271/api/CategoriaCliente/${id}`,
        {
          method: "PUT",
          headers: {
            "Content-Type": "application/json",
          },
          body: JSON.stringify({ 
            "id": id,
            "nome":  nomecategoria  }),
        }
      );

      if (response.ok) {
        console.log("Categoria editada com sucesso!");
        router.push("/categorias");
      } else {
        console.error("Erro ao editar categoria");
      }
    } catch (error) {
      console.error("Ocorreu um erro inesperado", error);
    }
  };

  return (
    <form onSubmit={handleSubmit} className="input-container2-form">
      <div className="input-container2">
        <input onChange={handleChange} value={nomecategoria} type="text" />
      </div>
      <button title="" type="submit" className="editCategory2">
        SALVAR
      </button>
    </form>
  );
};


