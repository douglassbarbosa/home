"use client";
 
import { useRouter } from "next/navigation";

export default function RemoveBtn({ id }) {
  const router = useRouter();
  const removeTopic = async () => {
    const confirmed = confirm("Deseja realmente apagar essa categoria?");

    if (confirmed) {
        const res = await fetch(`http://localhost:5271/api/CategoriaCliente/${id}`, {
            method: "DELETE",
          });         

      if (res.ok) {
        router.refresh();
      }
    }
  };

  return ( 
    <button onClick={removeTopic} className="remove-button">
       REMOVER
    </button>
  );
}