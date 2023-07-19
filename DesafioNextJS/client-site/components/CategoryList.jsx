// use client
import { useState, useEffect } from "react";
import Link from "next/link";
import RemoveBtn from "./RemoveBtn";
import { HiPencilAlt } from 'react-icons/hi/index';

const getData = async () => {
    try {
        const datas = await fetch('http://localhost:5271/api/CategoriaCliente', {
            cache: "no-store",
        });
        
        if (!datas.ok) {
            throw new Error('Failed to fetch topics');
        }
        return datas.json();
    } catch (error) {
        console.error('Error fetching data:', error);
        return []; // Retorna um array vazio em caso de erro.
    }
}

export default function CategoryList() {
    const [categorias, setCategorias] = useState([]);

    useEffect(() => {
        const fetchData = async () => {
            const data = await getData();
            setCategorias(data);
        };

        fetchData();
    }, []);

    return (
        <>
            {categorias.map((t) => (
                <div key={t._id} className="p4 border border-slate-300 my-3 flex justify-between gap-5 items-start">
                    <div>
                        <h3>{t.nome}</h3>
                    </div>
                    <div className="flex gap-2">
                        <RemoveBtn />
                        <Link href={`/editTopic/${t._id}`}>
                            <HiPencilAlt size={24} />
                        </Link>
                    </div>
                </div>
            ))}
        </>
    )
}
